using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Word;
using System.Text;
using Font = iTextSharp.text.Font;


namespace Learning_System.ExternalClass
{
    internal class UserFont
    {
        
        static BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\Times.TTF", BaseFont.IDENTITY_H, true);
        Font font = new Font(bf, 12, Font.NORMAL);

        public Font setFont(string style)
        {
            font.SetStyle(0);

            if (style == "HEADER")
                font.Size = 16;
            else if (style == "BIG")
                font.Size = 14;
            else if (style == "REGULAR")
                font.Size = 12;
            else if (style == "SMALL")
                font.Size = 10;

            if (style.Contains("HEADER") == true || style.Contains("BOLD") == true)
                font.SetStyle("bold");
            if (style.Contains("ITALIC") == true)
                font.SetStyle("italic");
            if (style.Contains("UNDERLINE") == true)
                font.SetStyle("underline");

            return font;
        }
    }
}
