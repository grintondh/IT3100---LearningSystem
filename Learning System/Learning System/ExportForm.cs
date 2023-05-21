using iTextSharp.text;
using iTextSharp.text.pdf;
using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Globalization;
using System.Text;

namespace Learning_System
{
    public partial class ExportForm : UserControl
    {
        public ExportForm()
        {
            InitializeComponent();

            JArray? contestJson = JsonProcessing.ImportJsonContentInDefaultFolder("contest.json", null, null);

            try
            {
                if (contestJson != null)
                {
                    DataProcessing contestData = new();
                    List<string> contestColumns = new() { "Name", "TimeStart" };
                    List<Type> contestType = new() { typeof(string), typeof(DateTime) };
                    List<string> contestKey = new() { "PRIMARY KEY", "" };

                    contestData.Import(contestColumns, contestType, contestKey);
                    contestData.Import(contestJson);

                    DataTable? _DT = contestData.Init().Sort("TimeStart asc").Get();

                    if(_DT != null)
                    {
                        for (int i = 0; i < _DT.Rows.Count; i++)
                        {
                            LinkLabel linklbl = new LinkLabel {
                                Name = "ExportForm_Linklbl" + i.ToString(),
                                Location = new Point(90, 150 + i * 45),
                                Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                                FlatStyle = FlatStyle.Flat,
                                TabIndex = 10,
                                Text = _DT.Rows[i].Field<string>("Name"),
                                Size = new Size(919, 30),
                            };

                            linklbl.Click += new EventHandler((sender, args) =>
                            {
                                Properties.Settings.Default["ChoosingContest"] = linklbl.Text;
                                Properties.Settings.Default.Save();

                                MessageBox.Show(Properties.Settings.Default.ChoosingContest, "Success", MessageBoxButtons.OK);
                            });

                            this.Controls.Add(linklbl);
                        }
                    }
                }
                else
                    throw new Exception();
            } catch (Exception ex) {
                MessageBox.Show("Can't load your contest file!\n" + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private DataProcessing questionData = new();
        private List<string> showColumns = new() { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
        private List<Type> showType = new() { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
        private readonly List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "" };
        private DataTable? DataTable = new();

        private void ExportForm_ExportBtn_Click(object sender, EventArgs e)
        {
            if(questionData.ImportedColumns == false)
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
                Filter = "PDF (*.pdf)|*.pdf"
            };
            dlg.ShowDialog();

            string? pdfPassword = null;
            if (ExportForm_EnablePWCbx.CheckState == CheckState.Checked)
                pdfPassword = ExportForm_PasswordTxt.Text;

            try
            {
                using (FileStream stream = new(dlg.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    Encoding.GetEncoding("windows-1252");

                    Document pdfDoc = new();
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    writer.SetEncryption(PdfWriter.STRENGTH40BITS, pdfPassword, null, 0);
                    pdfDoc.Open();

                    pdfDoc.AddCreationDate();
                    pdfDoc.AddTitle("Problems");

                    UserFont userFont = new();
                    NumberFormatInfo setPrecision = new()
                    {
                        NumberDecimalDigits = 2
                    };

                    if (DataTable == null)
                        throw new Exception();

                    for (int i = 0; i < DataTable.Rows.Count; i++)
                    {
                        DataRow row = DataTable.Rows[i];

                        string headerLine = "Question " + i.ToString() + ":";
                        Paragraph header = new(headerLine, userFont.setFont("BIG ITALIC BOLD"))
                        {
                            Alignment = Element.ALIGN_JUSTIFIED
                        };
                        pdfDoc.Add(header);

                        string? questionLine = row.Field<string>("Content");
                        if (questionLine != null)
                        {
                            Paragraph question = new(questionLine, userFont.setFont("REGULAR"))
                            {
                                Alignment = Element.ALIGN_JUSTIFIED
                            };
                            pdfDoc.Add(question);
                        }

                        JArray? choiceArray = row.Field<JArray>("Choice");
                        if(choiceArray != null)
                        {
                            foreach (var choiceLine in choiceArray)
                            {
                                QuestionChoice qc = choiceLine.ToObject<QuestionChoice>();
                                Paragraph choice = new(qc.choice, userFont.setFont("REGULAR"))
                                {
                                    Alignment = Element.ALIGN_JUSTIFIED
                                };
                                pdfDoc.Add(choice);
                            }

                            string weightLine = "";

                            foreach (var choiceLine in choiceArray)
                            {
                                if (weightLine.Length > 0)
                                    weightLine += "; ";

                                QuestionChoice qc = choiceLine.ToObject<QuestionChoice>();
                                weightLine += qc.mark.ToString("N", setPrecision);
                            }

                            pdfDoc.Add(Chunk.NEWLINE);

                            weightLine = "Trọng số điểm của các đáp án lần lượt: " + weightLine;
                            Paragraph weight = new(weightLine, userFont.setFont("REGULAR ITALIC"))
                            {
                                Alignment = Element.ALIGN_JUSTIFIED
                            };
                            pdfDoc.Add(weight);
                        }

                        pdfDoc.Add(Chunk.NEWLINE);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't save your pdf file!\n" + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void ExportForm_EnablePWCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ExportForm_EnablePWCbx.CheckState == CheckState.Checked)
                ExportForm_PasswordTxt.ReadOnly = false;
            else
                ExportForm_PasswordTxt.ReadOnly = true;
        }
    }
}
