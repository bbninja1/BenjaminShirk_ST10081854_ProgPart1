using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenjaminShirk_ST10081854_ProgPart1
{
    public partial class Identifying_Areas_Game : Form
    {
        /// <summary>
        /// variables
        /// </summary>
        private Identifying_Areas identfiyingAreas;
        private int gameAlternatater = 0;
        private object Item;
        private ListBox DropItem;
        private int Score = 0;
        private int totalScore = 0;
        public Identifying_Areas_Game()
        {
            InitializeComponent();
            ResetGame();
        }

        #region CreateQuestion
        // match the columns question
        public void CreateQuestion()
        {
            this.gameAlternatater++; //increasing game number
            this.identfiyingAreas = new Identifying_Areas();
            this.identfiyingAreas.AlternativeQuestionsColumn1 = gameAlternatater;
            this.identfiyingAreas.GenerateQuestion(); //generating question
            ClearListBox();
            SetupQuestion();
        }
        #endregion

        #region SetUpQuestion
        //match the columns question that was generated
        public void SetupQuestion()
        {
            Score = 0; //reset current score for next question
            if (gameAlternatater % 2 == 0)
            {
                //even numbers
                string[] questions = identfiyingAreas.AlternativeDictionary1.Keys.ToArray();
                SetupLeftColumn(questions); 
                List<string> EList = identfiyingAreas.AlternativeDictionary1.Values.ToList();
                EList.AddRange(identfiyingAreas.AlternateArray1);
                EList = identfiyingAreas.Shuffle(EList); //shuffle
                SetupRightColumn(EList);
            }
            //odd descriptions
            else
            {
                //questions
                string[] questions = identfiyingAreas.AlternativeDictionary1.Values.ToArray();
                SetupLeftColumn(questions);
                //answers combining the dictionary with wrong answers list
                List<string> EList = identfiyingAreas.AlternativeDictionary1.Keys.ToList();
                EList.AddRange(identfiyingAreas.AlternateArray1);
                EList = identfiyingAreas.Shuffle(EList); //shuffle
                SetupRightColumn(EList);
            }
        }
        #endregion

        #region LeftColumnSetUp
        //left side of the questions set up
        public void SetupLeftColumn(string[] LeftColumn)
        {
            int increment = 0;
            var ChangeLabelsToQuestions = ColumnPanel1.Controls.OfType<Label>().Where(c => c.Name.StartsWith("lbl")).ToList();
            ChangeLabelsToQuestions.Reverse();
            foreach (Label lbl in ChangeLabelsToQuestions)
            {
                lbl.Text = LeftColumn[increment];
                increment++;
            }
        }
        #endregion

        #region RightColumnSetUp
        //setup the right side (answers)
        public void SetupRightColumn(List<string> RightColumn)
        {
            lstAnswerList.Items.Clear();
            foreach (var item in RightColumn)
            {
                lstAnswerList.Items.Add(item);
            }
        }
        #endregion

        #region Mouse Down
        ///Drag and drop list boxxes 
        private void Answer_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ListBox Drag = (ListBox)sender;
                DropItem = Drag;
                if (Drag.SelectedItem != null)
                {
                    string text = Drag.SelectedItem.ToString();
                    Item = Drag.SelectedItem;
                    DoDragDrop(text, DragDropEffects.Copy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }

        ///  allowing list box dragging
        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            //data is text format
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        #endregion

        #region ListBox Drag Drop
        //answer is dropped into a listbox
        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                string text = e.Data.GetData("Text", true) as string;


                ListBox lstListBox = (ListBox)sender;
                if (lstListBox != DropItem)
                {

                    if ((lstListBox != lstAnswerList) && (lstListBox.Items.Count < 1))
                    {
                        DropItem.Items.Remove(Item);
                        lstListBox.Items.Add(text);
                        ValidateAnswer();
                    }
                    if (lstListBox == lstAnswerList)
                    {
                        DropItem.Items.Remove(Item);
                        lstListBox.Items.Add(text);
                        ValidateAnswer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }
        #endregion

        #region Answer Check
        //Check if the answer was correct
        public void ValidateAnswer()
        {
            //score 
            int score = 0;

            foreach (ListBox listBox in ColumnPanel1.Controls.OfType<ListBox>().ToList())
            {
                if (listBox.Items.Count != 0)
                {
                    string listBoxName = listBox.Name;
                    string answer = listBox.Items[0].ToString();
                    int index = int.Parse(listBoxName.Substring(6)) - 1;
                    string question = "";
                    bool isCorrect;

                    if (gameAlternatater % 2 == 0)
                    {
                        question = identfiyingAreas.AlternativeDictionary1.ElementAt(index).Key;
                        isCorrect = identfiyingAreas.Validate(question, answer);
                    }
                    else
                    {
                        question = identfiyingAreas.AlternativeDictionary1.ElementAt(index).Value;
                        isCorrect = identfiyingAreas.Validate(answer, question);
                    }

                    if (isCorrect)
                    {
                        listBox.ForeColor = Color.DarkGreen;
                        score++;
                    }
                    else
                    {
                        listBox.ForeColor = Color.Red;
                    }
                }
            }
            UpdateScore(score);
        }
        #endregion

        #region Clear List Box
        // clear the answer boxes when a new question is generated
        private void ClearListBox()
        {
            var lstAnswerBox = ColumnPanel1.Controls.OfType<ListBox>().ToList();
            foreach (var item in lstAnswerBox)
            {
                item.Items.Clear();
            }
        }
        #endregion

        #region Update Score
        // update the score of the game
        private void UpdateScore(int Update)
        {
            Score = Update;
        }
        #endregion

        #region Reset Game
        //reset game
        private void ResetGame()
        {
            gameAlternatater = 0;
            totalScore = 0;
            Score = 0;
            CreateQuestion();
        }
        #endregion

        #region Menu Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Take you back to the Menu
            this.Hide();
            Menu HomePage = new Menu();
            HomePage.Show();
        }
        #endregion

        #region Help Button
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Help Center of Indentifying Areas!\n\n" +
                               "Welcome To The Game Indentifying Areas\n" +
                               "Identifying Areas is a column matching game where you are to match the callnumber with the description\n\n" +
                               "Please have fun and enjoy!",
                               "BookMania",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
        }
        #endregion

        #region ResetPBBar
        public void ResetPBBar()
        {
            PBBookGameProgressBar.Value = 0;
        }
        #endregion

        #region Enter
        private void btnEnter_Click(object sender, EventArgs e)
        {
            totalScore += Score;
            lblScoreNumber.Text = Score.ToString();
            lblTotalScoreNumber.Text = totalScore.ToString();
            PBBookGameProgressBar.Increment(Score * 25);
        }
        #endregion

        #region Reset Score
        private void btnResetScore_Click(object sender, EventArgs e)
        {
            totalScore = 0;
            Score = 0;
            lblScoreNumber.Text = "0";
            lblTotalScoreNumber.Text = "0";
        }
        #endregion

        #region Next Question
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            CreateQuestion();
            ResetPBBar();
        }
        #endregion

    }
}
//-------------------------------------------EndOFFile-----------------------------------------//
