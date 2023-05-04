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

        private char CheckChoicesAikenFormat(string choice)
        {
            if (choice.Length < 4) return ' ';
            return choice[0] < 'A' || choice[0] > 'Z' || choice[1] != '.' || choice[2] != ' ' || choice[3] == ' ' ? ' ' : choice[0];
        }

        private bool CheckAnswerAikenFormat(string answer, List<char> _listAnswers)
        {
            if (answer.Length != 9) return false;
            if (answer[..8] != "ANSWER: ") return false;
            foreach (char c in _listAnswers)
            {
                if (answer.EndsWith(c)) return true;
            }
            return false;
        }
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
                    List<char> listAnswers = new List<char>();
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
                else return i;
            }
            return -questionCount;
        }

        private void ImportQuestionsFile(List<string> lines)
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
                JArray _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
                questionsData.Import(_showQuestionsColumns, _showQuestionsType, _showQuestionsKey);
                questionsData.Import(_questionsData);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Can't get questions data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                    Application.Exit();
            }

            try
            {
                JArray _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                categoriesData.Import(_showCategoryColumns, _showCategoryType, _showCategoryKey);
                categoriesData.Import(_categoriesData);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                    Application.Exit();
            }

            List<string> _query = new List<string> { "Id", "0" };
            DataRow _parentCategory = categoriesData.Init().Offset(0).Limit(1).Query(_query).Sort("Id desc").GetFirstRow();
            if (_parentCategory == null)
            {
                MessageBox.Show("Thêm thất bại do không tồn tại category thoả mãn", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int questionIDCount = questionsData.Length() - 1;

            int i = 0;
            while (i < lines.Count)
            {
                if (lines[i].Length > 0)
                {
                    string questionContent = lines[i];
                    questionIDCount++;
                    i++;
                    List<QuestionChoice> _questionChoices = new List<QuestionChoice>();
                    while (lines[i].Length > 0)
                    {
                        if (lines[i][1] == '.')
                        {
                            QuestionChoice _questionChoice = new QuestionChoice()
                            {
                                choice = lines[i],
                                mark = 0
                            };
                            _questionChoices.Add(_questionChoice);
                            i++;
                        }
                        else
                        {
                            foreach (QuestionChoice _questionChoice in _questionChoices)
                            {
                                if (lines[i].EndsWith(_questionChoice.choice[0])) _questionChoice.mark = 1;
                            }
                            i += 2;
                            break;
                        }
                    }
                    Questions newQuestions = new Questions()
                    {
                        ID = questionIDCount,
                        Name = "",
                        CategoryID = 0,
                        Content = questionContent,
                        DefaultMark = 1,
                        Choice = _questionChoices
                    };

                    questionsData.Insert(JObject.FromObject(newQuestions));

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
                List<string> lines = File.ReadAllLines(ImportPath).ToList();
                int checkAikenFormat = CheckAikenFormat(lines);
                if (checkAikenFormat >= 0)
                {
                    MessageBox.Show($"Error at line {checkAikenFormat + 1}!");
                }
                else
                {
                    MessageBox.Show($"OK. Successfully imported {-checkAikenFormat} question(s)!");
                    ImportQuestionsFile(lines);
                    ImportForm_StatusLbl.Text = "Maximum size for new files: ___";
                    ImportPath = null;
                }
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
