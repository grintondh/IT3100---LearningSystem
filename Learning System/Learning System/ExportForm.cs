using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows;
using Font = iTextSharp.text.Font;

namespace Learning_System
{
    public partial class ExportForm : UserControl
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private readonly string s = "";

        private class defaultFont {
            Font font = new Font();
            public Font setFont(string style)
            {
                font.SetStyle(0);
                if (style == "HEADER")
                    font.Size = 18;
                else if(style == "REGULAR")
                    font.Size = 16;
                else if(style == "SMALL")
                    font.Size = 14;

                if (style.Contains("HEADER") == true || style.Contains("BOLD") == true)
                    font.SetStyle("bold");
                if (style.Contains("ITALIC") == true)
                    font.SetStyle("italic");

                return font;
            }
        }

        private void ExportForm_ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save your exported PDF file at:";
            dlg.Filter = "PDF (*.pdf)|*.pdf";
            dlg.ShowDialog();

            try
            {
                using (FileStream stream = new FileStream(dlg.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document();
                    defaultFont defaultFont = new defaultFont();


                    Paragraph header = new Paragraph("Hello", defaultFont.setFont("HEADER ITALIC"));
                    header.Alignment = Element.ALIGN_CENTER;

                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(header);

                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch
            {
                MessageBox.Show("Can't save your pdf file!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
