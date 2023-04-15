using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_System
{
    public partial class ImportForm : UserControl
    {
        private string? ImportPath;
        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_SelectFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All File (*.*)|*.*|File Text(*.txt)|*.txt|File .doc(*.doc)|*.doc|File .docx (*.docx)|.docx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportPath = openFileDialog.FileName;
                ImportForm_StatusLbl.Text = "File choosen: " + Path.GetFileName(openFileDialog.FileName);
            }
        }
        private bool CheckAikenFormat(string _ImportPath)
        {
            return true;
        }
        private bool CheckFileFormat(string _ImportPath)
        {
            if (Path.GetExtension(_ImportPath) != ".txt" && Path.GetExtension(_ImportPath) != ".doc" && Path.GetExtension(_ImportPath) != ".docx")
            {
                return false;
            }
            else return true;
        }

        private void ImportForm_ImportBtn_Click(object sender, EventArgs e)
        {
            if (ImportPath == null)
            {
                MessageBox.Show("Please choose a file!");
            }
            else if (CheckFileFormat(ImportPath) == false)
            {
                MessageBox.Show("Wrong format!");
            }
            else if (CheckAikenFormat(ImportPath) == false)
            {
                MessageBox.Show("Error at ...");
            }
            else
            { 
                MessageBox.Show("Success ...");
                ImportForm_StatusLbl.Text = "Maximum size for new files: ___";
                ImportPath = null;
            }
        }

        private void panel_drop_file_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            ImportPath = FileList[0];
            ImportForm_StatusLbl.Text = "File choosen: " + Path.GetFileName(ImportPath);
        }

        private void panel_drop_file_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else e.Effect = DragDropEffects.None;
        }

    }
}
