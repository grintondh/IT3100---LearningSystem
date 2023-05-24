using Learning_System.ExternalClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Learning_System
{
    public partial class ImportForm : UserControl
    {
        private string? ImportPath;

        private string? selectedImage;

        private Paragraph? paragraph;

        private int lineIndex = 0;

        private const long SIZE_OF_MB = 1024 * 1024;

        private const int MAX_OF_SIZE = 200;

        private double maximumSizeForNewFiles = MAX_OF_SIZE;

        const int MAX_OF_LINES = 2000;

        private RichTextBox[] lineTextBoxes = new RichTextBox[MAX_OF_LINES];

        public ImportForm()
        {
            InitializeComponent();
            ImportForm_StatusLbl.Text = $"Maximum size for new files: {Math.Round(maximumSizeForNewFiles, 2)} MB";
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

        /// <summary>
        /// Check Aiken format của dòng lựa chọn ("A. Choice's content")
        /// </summary>
        private char CheckChoicesAikenFormat(string choice)
        {
            if (choice.Length < 4) return ' ';
            return choice[0] < 'A' || choice[0] > 'Z' || choice[1] != '.' || choice[2] != ' ' || choice[3] == ' ' ? ' ' : choice[0];
        }

        /// <summary>
        /// Check Aiken format của dòng đáp án ("ANSWER: A")
        /// </summary>
        /// <param name="answer"> Dòng đáp án</param>
        /// <param name="_listAnswers"> Danh sách các lựa chọn của câu hỏi</param>
        private bool CheckAnswerAikenFormat(string answer, List<char> _listAnswers)
        {
            if (_listAnswers.Count < 2) return false;
            if (answer.Length != 9) return false;
            if (answer[..8] != "ANSWER: ") return false;
            foreach (char c in _listAnswers)
            {
                if (answer.EndsWith(c)) return true;
            }
            return false;
        }
        /// <summary>
        /// Check Aiken format của file
        /// </summary>
        /// <param name="lines"> Các dòng text trong file</param>
        /// <returns> Số âm: Đúng format và trả về số câu hỏi trong file; Số dương: Sai format và trả về dòng đầu tiên bị sai format </returns>
        private int CheckAikenFormat(List<string> lines)
        {
            int i = 0;
            int questionCount = 0;
            while (i < lines.Count)
            {
                if (lines[i].Length > 0)
                {
                    questionCount++;
                    i++;
                    List<char> listAnswers = new();
                    try
                    {
                        while (lines[i] != null)
                        {
                            if (!CheckAnswerAikenFormat(lines[i], listAnswers))
                            {
                                if (CheckChoicesAikenFormat(lines[i]) == ' ') return i;
                                listAnswers.Add(CheckChoicesAikenFormat(lines[i]));
                                i++;
                            }
                            else
                            {
                                i++;
                                if (i == lines.Count) break;
                                if (lines[i].Length > 0) return i;
                                i++;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return i;
                        throw;
                    }
                }
                else return i;
            }
            return -questionCount;
        }

        /// <summary>
        /// Import câu hỏi vào file json
        /// </summary>
        /// <param name="lines"> Các dòng text trong file</param>
        /// <param name="_ImportPath"> Đường dẫn của file được chọn</param>
        private void ImportQuestionsFile(List<string> lines, string _ImportPath)
        {
            DataProcessing questionsData = new();
            List<string> _showQuestionsColumns = new() { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
            List<Type> _showQuestionsType = new() { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
            List<string> _showQuestionsKey = new() { "PRIMARY KEY", "", "", "", "", "" };


            DataProcessing categoriesData = new();
            List<string> _showCategoryColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
            List<Type> _showCategoryType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
            List<string> _showCategoryKey = new() { "PRIMARY KEY", "", "", "", "", "" };


            try
            {
                JArray? _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
                if (_questionsData == null)
                {
                    MessageBox.Show("Can't get questions data:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                questionsData.Import(_showQuestionsColumns, _showQuestionsType, _showQuestionsKey);
                questionsData.Import(_questionsData);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Can't get questions data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }

            try
            {
                JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                if (_categoriesData == null)
                {
                    MessageBox.Show("Can't get categories data:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                categoriesData.Import(_showCategoryColumns, _showCategoryType, _showCategoryKey);
                categoriesData.Import(_categoriesData);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }

            List<string> _query = new() { "Id", "0" };
            DataRow? _parentCategory = categoriesData.Init().Offset(0).Limit(1).Query(_query).Sort("Id desc").GetFirstRow();
            if (_parentCategory == null)
            {
                MessageBox.Show("Thêm thất bại do không tồn tại category thoả mãn", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow? _maxQuestionIdRow = questionsData.Init()
                                                       .Offset(0)
                                                       .Limit(questionsData.Length())
                                                       .Sort("ID desc")
                                                       .GetFirstRow();

            int questionIDCount = (_maxQuestionIdRow == null) ? 0 : (_maxQuestionIdRow.Field<int>("ID"));

            int i = 0;
            while (i < lines.Count)
            {
                if (lines[i].Length > 0)
                {
                    string _stringContent;
                    if (Path.GetExtension(ImportPath) != ".txt") _stringContent = lineTextBoxes[i].Rtf;
                    else _stringContent = lines[i];
                    string questionContent = _stringContent;
                    questionIDCount++;
                    i++;
                    List<QuestionChoice> _questionChoices = new();
                    while (lines[i].Length > 0)
                    {
                        if (lines[i][1] == '.')
                        {
                            if (Path.GetExtension(ImportPath) != ".txt") _stringContent = lineTextBoxes[i].Rtf;
                            else _stringContent = lines[i];
                            QuestionChoice _questionChoice = new()
                            {
                                choice = _stringContent,
                                mark = 0
                            };
                            _questionChoices.Add(_questionChoice);
                            i++;
                        }
                        else
                        {
                            int j = 0;
                            foreach (QuestionChoice _questionChoice in _questionChoices)
                            {
                                if (lines[i].EndsWith(lines[i - _questionChoices.Count + j][0])) _questionChoice.mark = 1;
                                j++;
                            }
                            i += 2;
                            break;
                        }
                    }
                    Questions newQuestions = new()
                    {
                        ID = questionIDCount,
                        Name = "",
                        CategoryID = 0,
                        Content = questionContent,
                        DefaultMark = 1,
                        Choice = _questionChoices
                    };

                    questionsData.Insert(JObject.FromObject(newQuestions));
                    if (_parentCategory.Field<JArray>("QuestionArray") == null)
                    {
                        MessageBox.Show("Can't get parents categories data:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    _parentCategory.Field<JArray>("QuestionArray").Add(newQuestions.ID);
                }
            }

            JObject x = DataProcessing.ConvertDataRowToJObject(_parentCategory);

            categoriesData.Init().Query(_query).Update(JObject.FromObject(x));

            JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", questionsData.Export());

            JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export());
            return;
        }



        private bool CheckFileFormat(string _ImportPath)
        {
            if (Path.GetExtension(_ImportPath) != ".txt" && Path.GetExtension(_ImportPath) != ".doc" && Path.GetExtension(_ImportPath) != ".docx")
            {
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Copy dòng đang được selected từ file .doc hoặc .docx để paste vào Rich Text Box.
        /// </summary>
        protected void CopyFromClipboardInlineShape()
        {
            if (paragraph == null) return;
            //InlineShape inlineShape = paragraph.Range.InlineShapes[selectedImageIndex];
            paragraph.Range.Select();
            paragraph.Range.Copy();
            Computer computer = new();
            //Image img = computer.Clipboard.GetImage();
            if (computer.Clipboard.GetDataObject() != null)
            {
                RichTextBox t = new();
                lineTextBoxes[lineIndex] = new RichTextBox();
                t.Paste();
                selectedImage = t.Rtf;
                //System.Windows.Forms.IDataObject data = computer.Clipboard.GetDataObject();
                //if (data.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap))
                //{
                //    Image image = (Image)data.GetData(System.Windows.Forms.DataFormats.Bitmap, true);
                //    RichTextBox textBox = new RichTextBox();
                //    DataFormats.Format format = DataFormats.GetFormat(System.Windows.Forms.DataFormats.Bitmap);
                //    textBox.Paste(format);
                //    selectedImage = textBox.Rtf;
                //}
                //else
                //{
                //    selectedImage = "";
                //}
            }
            else
            {
                selectedImage = "";
            }
        }

        /// <summary>
        /// Đọc file .txt, .doc, .docx được chọn
        /// </summary>
        /// <param name="_ImportPath"> Đường dẫn của file được chọn </param>
        /// <returns>Trả về list các dòng text trong file, nếu là file doc thì paste content vào mảng Rich Text Box </returns>
        private List<string> ReadFromDocumentFile(string _ImportPath)
        {
            List<string> _lines = new();
            if (Path.GetExtension(_ImportPath) == ".txt")
            {
                _lines = File.ReadAllLines(_ImportPath).ToList();
            }
            else
            {
                Microsoft.Office.Interop.Word.Application application = new();
                object miss = Missing.Value;
                object path = _ImportPath;
                object readOnly = true;
                object save = false;
                Document docs = application.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
                if (docs != null)
                {
                    if (docs.Paragraphs.Count > MAX_OF_LINES)
                    {
                        MessageBox.Show($"Maximum {MAX_OF_LINES} lines on .doc and .docx files!");
                        return _lines;
                    }
                    lineIndex = 0;
                    foreach (Paragraph p in docs.Paragraphs)
                    {
                        paragraph = p;
                        //_lines.Add(CopyFromClipboardInlineShape());
                        Thread thread = new(CopyFromClipboardInlineShape);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                        thread.Join();
                        lineTextBoxes[lineIndex] = new RichTextBox
                        {
                            Rtf = selectedImage
                        };
                        _lines.Add(lineTextBoxes[lineIndex].Text.Trim());
                        lineIndex++;
                        //totaltext += p.Range.Text;
                    }
                    //string[] _totaltext = totaltext.Split('\r');
                    //_lines.AddRange(_totaltext);
                    docs.Close(ref save, ref miss, ref miss);
                }
                application.Quit(ref save, ref miss, ref miss);
            }
            return _lines;
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
            else
            {
                double fileSize = new System.IO.FileInfo(ImportPath).Length;
                if (fileSize >= MAX_OF_SIZE * SIZE_OF_MB)
                {
                    MessageBox.Show($"File's size must be smaller than {MAX_OF_SIZE} MB!");
                    return;
                }
                List<string> lines = ReadFromDocumentFile(ImportPath);
                if (lines == null) { return; }
                int checkAikenFormat = CheckAikenFormat(lines);
                if (checkAikenFormat >= 0)
                {
                    MessageBox.Show($"Error at line {checkAikenFormat + 1}!");
                }
                else
                {
                    MessageBox.Show($"OK. Successfully imported {-checkAikenFormat} question(s)!");
                    ImportQuestionsFile(lines, ImportPath);
                    maximumSizeForNewFiles -= fileSize / SIZE_OF_MB;
                    ImportForm_StatusLbl.Text = $"Maximum size for new files: {Math.Round(maximumSizeForNewFiles, 2)} MB";
                }
                ImportPath = null;
                selectedImage = null;
                paragraph = null;
            }
        }

        private void Panel_drop_file_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null) {
                MessageBox.Show("Please dragdrop a file here");
                return; 
            }
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            ImportPath = FileList[0];
            ImportForm_StatusLbl.Text = "File choosen: " + Path.GetFileName(ImportPath);
        }

        private void Panel_drop_file_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                MessageBox.Show("Please dragdrop a file here");
                return;
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else e.Effect = DragDropEffects.None;
        }
    }
}
