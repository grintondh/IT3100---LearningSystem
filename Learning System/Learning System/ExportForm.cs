using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Globalization;
using System.Text;
using RtfPipe;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Html2pdf;
using iText.Html2pdf.Resolver.Font;
using System.Diagnostics;

namespace Learning_System
{
    public partial class ExportForm : UserControl
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private DataProcessing questionData = new();
        private List<string> showColumns = new() { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
        private List<Type> showType = new() { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
        private readonly List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "" };
        private DataTable? DataTable = new();

        private void ExportForm_ExportBtn_Click(object sender, EventArgs e)
        {
            ExportForm_progressLabel.Text = "Processing... ";

            if (questionData.ImportedColumns == false)
            {
                JArray? _questionData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
                if (_questionData != null)
                {
                    questionData.Import(showColumns, showType, showKey);
                    questionData.Import(_questionData);
                    DataTable = questionData.Init().Limit(questionData.Length()).Get();
                }
                else
                {
                    MessageBox.Show("Can't load your question file!", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            SaveFileDialog dlg = new SaveFileDialog
            {
                Title = "Save your exported PDF file at:",
                Filter = "PDF (*.pdf)|*.pdf",
                RestoreDirectory = true
            };
            dlg.ShowDialog();

            string? pdfPassword = null;
            if (ExportForm_EnablePWCbx.CheckState == CheckState.Checked)
                pdfPassword = ExportForm_PasswordTxt.Text;

            string RandomGUIDForTempFile = Guid.NewGuid().ToString();

            try
            {
                using (FileStream stream = new(dlg.FileName, FileMode.Create))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    Encoding.GetEncoding("utf-32");
                    PdfWriter writer;

                    if (pdfPassword != null)
                    {
                        WriterProperties writerProperties = new WriterProperties();
                        byte[] PASS = Encoding.Default.GetBytes(pdfPassword);
                        writerProperties.SetStandardEncryption(PASS, PASS, EncryptionConstants.ALLOW_PRINTING, EncryptionConstants.ENCRYPTION_AES_128);
                        writer = new PdfWriter(stream, writerProperties);
                    }
                    else
                    {
                        writer = new PdfWriter(stream);
                    }

                    PdfDocument pdf = new PdfDocument(writer);
                    iText.Layout.Document pdfDoc = new iText.Layout.Document(pdf, pageSize: iText.Kernel.Geom.PageSize.A4);

                    try
                    {
                        NumberFormatInfo setPrecision = new()
                        {
                            NumberDecimalDigits = 2
                        };

                        if (DataTable == null)
                            throw new Exception();

                        ExportForm_progressBar.Maximum = DataTable.Rows.Count;
                        ExportForm_progressBar.Value = 0;

                        for (int i = 0; i < DataTable.Rows.Count; i++)
                        {
                            DataRow row = DataTable.Rows[i];

                            string headerLine = "Question " + i.ToString() + ":";
                            Paragraph header = new(new Text(headerLine));
                            header.SetFont(UserFont.GetFont("BOLD")).SetFontSize(14).SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED);
                            pdfDoc.Add(header);

                            string? questionLine = row.Field<string>("Content");

                            if (questionLine != null)
                            {
                                Task task = AddRTFToPdf(pdfDoc, questionLine, RandomGUIDForTempFile);
                                task.Wait();
                            }

                            JArray? choiceArray = row.Field<JArray>("Choice");
                            if (choiceArray != null)
                            {
                                foreach (var choiceLine in choiceArray)
                                {
                                    QuestionChoice qc = choiceLine.ToObject<QuestionChoice>();
                                    Task task = AddRTFToPdf(pdfDoc, qc.choice, RandomGUIDForTempFile);
                                    task.Wait();
                                }

                                string weightLine = "";

                                foreach (var choiceLine in choiceArray)
                                {
                                    if (weightLine.Length > 0)
                                        weightLine += "; ";

                                    QuestionChoice qc = choiceLine.ToObject<QuestionChoice>();
                                    weightLine += qc.mark.ToString("N", setPrecision);
                                }

                                Paragraph weight = new();
                                weight.Add(new Text("Trọng số điểm của các đáp án lần lượt: " + weightLine));
                                weight.SetFont(UserFont.GetFont("ITALIC")).SetFontSize(14).SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED); ;
                                pdfDoc.Add(weight);
                            }

                            if (ExportForm_progressLabel.Text == "Error")
                                throw new Exception();

                            ExportForm_progressBar.Increment(1);
                            ExportForm_progressLabel.Text = "Processing... " + ExportForm_progressBar.Value + "/" + ExportForm_progressBar.Maximum;
                        }

                        ExportForm_progressLabel.Text = "Completed!";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't save your pdf file!\n" + ex, "Error", MessageBoxButtons.OK);
                        ExportForm_progressLabel.Text = "Error";
                    }
                    finally
                    {
                        pdfDoc.Close();
                        if (ExportForm_OpenAfterExportCbx.Checked == true)
                        {
                            using (Process openPdf = new Process())
                            {
                                openPdf.StartInfo = new ProcessStartInfo()
                                {
                                    CreateNoWindow = true,
                                    UseShellExecute = true,
                                    Verb = "",
                                    FileName = dlg.FileName
                                };

                                openPdf.Start();
                            }
                        }

                        try
                        {
                            File.Delete("tempRTF" + RandomGUIDForTempFile + ".rtf");
                            File.Delete("tempHTML" + RandomGUIDForTempFile + ".html");
                        } 
                        finally
                        {
                            MessageBox.Show("Your pdf file is exported successfully!", "Success", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't save your pdf file!\n" + ex, "Error", MessageBoxButtons.OK);
                ExportForm_progressLabel.Text = "Error";
            }
        }

        private void ExportForm_EnablePWCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ExportForm_EnablePWCbx.CheckState == CheckState.Checked)
            {
                ExportForm_ShowPwdCbx.Enabled = true;
                ExportForm_ShowPwdCbx.Text = "Show password";
                ExportForm_ShowPwdCbx.Checked = false;
                ExportForm_PasswordTxt.PasswordChar = '*';
                ExportForm_PasswordTxt.ReadOnly = false;
            }
            else
            {
                ExportForm_ShowPwdCbx.Enabled = false;
                ExportForm_ShowPwdCbx.Text = "Show password";
                ExportForm_ShowPwdCbx.Checked = false;
                ExportForm_PasswordTxt.PasswordChar = '*';
                ExportForm_PasswordTxt.ReadOnly = true;
            }

        }

        [Obsolete]
        private Task AddRTFToPdf(iText.Layout.Document pdfDoc, string rtfString, string RandomGUID)
        {
            RichTextBox rtb = new();
            try
            {
                rtb.Rtf = rtfString;
            }
            catch
            {
                rtb.Rtf = null;
                Paragraph par = new(new Text(rtfString));
                par.SetFont(UserFont.GetFont("REGULAR")).SetFontSize(14).SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED);
                pdfDoc.Add(par);
                return Task.CompletedTask;
            }

            string fileLocation = "tempRTF" + RandomGUID + ".rtf";
            rtb.SaveFile(fileLocation);

            var htmlDoc = Rtf.ToHtml(rtfString);
            File.WriteAllText("tempHTML" + RandomGUID + ".html", htmlDoc);

            try
            {
                using (var stream = File.Open("tempHTML" + RandomGUID + ".html", FileMode.Open))
                {
                    StreamReader tr = new StreamReader(stream);
                    ConverterProperties properties = new ConverterProperties();
                    properties.SetFontProvider(new DefaultFontProvider(true, true, true));

                    IList<IElement> list = HtmlConverter.ConvertToElements(stream, properties);
                    foreach (var listElement in list)
                    {
                        pdfDoc.Add((IBlockElement)listElement).SetFont(UserFont.GetFont("REGULAR"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't save your pdf file!\n" + ex, "Error", MessageBoxButtons.OK);
                ExportForm_progressLabel.Text = "Error";
            }

            return Task.CompletedTask;
        }

        private void ExportForm_ShowPwdCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ExportForm_ShowPwdCbx.Checked == true)
            {
                ExportForm_PasswordTxt.PasswordChar = '\0';
                ExportForm_ShowPwdCbx.Text = "Hide password";
            }
            else
            {
                ExportForm_PasswordTxt.PasswordChar = '*';
                ExportForm_ShowPwdCbx.Text = "Show password";
            }
        }
    }
}
