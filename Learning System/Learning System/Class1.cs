using System;
using System.Drawing;
using System.IO;
using System.Threading;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic.Devices;
public partial class ReadIMG : UserControl 
{
    private Microsoft.Office.Interop.Word.Application m_word = new Microsoft.Office.Interop.Word.Application();
    private int m_i;
    protected void Page_Load(object sender, EventArgs e, string FilePath)
    {
        object missing = Type.Missing;
        object FileName = FilePath;
        object readOnly = true;
        m_word = new Microsoft.Office.Interop.Word.Application();
        m_word.Documents.Open(ref FileName,
                                ref missing, ref readOnly, ref missing, ref missing,
                                ref missing, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        try
        {
            for (int i = 1; i <= m_word.ActiveDocument.InlineShapes.Count; i++)
            {
                m_i = i;
                // CopyFromClipboardShape();
                Thread thread = new Thread(CopyFromClipbordInlineShape);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
            }
        }
        finally
        {
            object save = false;
            m_word.Quit(ref save, ref missing, ref missing);
            m_word = null;
        }
    }
    protected void CopyFromClipbordInlineShape()
    {
        InlineShape inlineShape = m_word.ActiveDocument.InlineShapes[m_i];
        inlineShape.Select();
        m_word.Selection.Copy();
        Computer computer = new Computer();
        //Image img = computer.Clipboard.GetImage();
        if (computer.Clipboard.GetDataObject() != null)
        {
            System.Windows.Forms.IDataObject data = computer.Clipboard.GetDataObject();
            if (data.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap))
            {
                Image image = (Image)data.GetData(System.Windows.Forms.DataFormats.Bitmap, true);

            }
            else
            {

            }
        }
        else
        {

        }
    }
}