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
        /// <summary>
        /// Creat Question Method
        /// </summary>
        // match the columns question
        public void CreateQuestion()
        {
            //increasing Alternator number
            this.gameAlternatater++; 
            this.identfiyingAreas = new Identifying_Areas();
            this.identfiyingAreas.AlternativeQuestionsColumn1 = gameAlternatater;
            //generating question
            this.identfiyingAreas.GenerateQuestion();
            //Clear ListBoxes
            ClearListBox();
            //Input values into the ListBoxes and labels
            SetupQuestion();
        }
        #endregion

        #region SetUpQuestion
        /// <summary>
        /// SetUp The Lists Questions
        /// </summary>
        //match the columns question that was generated
        public void SetupQuestion()
        {
            Score = 0; //reset current score for next question
            if (gameAlternatater % 2 == 0)
            {
                //Even Numbers Questions
                string[] questions = identfiyingAreas.AlternativeDictionary1.Keys.ToArray();
                SetupLeftColumn(questions); 

                //Local List To hold Dictionary Data
                List<string> EList = identfiyingAreas.AlternativeDictionary1.Values.ToList();
                EList.AddRange(identfiyingAreas.AlternateArray1);

                //shuffle Lists
                EList = identfiyingAreas.Shuffle(EList); 
                SetupRightColumn(EList);
            }
            else
            {
                //Odd Number Questions
                string[] questions = identfiyingAreas.AlternativeDictionary1.Values.ToArray();
                SetupLeftColumn(questions);

                //Local List To hold Alternative Data
                List<string> EList = identfiyingAreas.AlternativeDictionary1.Keys.ToList();
                EList.AddRange(identfiyingAreas.AlternateArray1);

                //shuffle Lists
                EList = identfiyingAreas.Shuffle(EList); 
                SetupRightColumn(EList);
            }
        }
        #endregion

        #region LeftColumnSetUp
        /// <summary>
        /// Populate Left Side Column
        /// </summary>
        /// <param name="LeftColumn"></param>
        public void SetupLeftColumn(string[] LeftColumn)
        {
            int increment = 0;
            var LabelsChange = ColumnPanel1.Controls.OfType<Label>().Where(c => c.Name.StartsWith("lbl")).ToList();
            LabelsChange.Reverse();
            foreach (Label lbl in LabelsChange)
            {
                lbl.Text = LeftColumn[increment];
                increment++;
            }
        }
        #endregion

        #region RightColumnSetUp
        /// <summary>
        /// Populate Right Side Column
        /// </summary>
        /// <param name="RightColumn"></param>
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
        /// <summary>
        /// Drag and drop using Mouse 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// Drag And Drop Into Respective List Box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Check if the answer was correct and then change colour if correct or incorrect plus increase score
        /// </summary>
        public void ValidateAnswer()
        {
            int score = 0;

            //for each loop 
            foreach (ListBox listBox in ColumnPanel1.Controls.OfType<ListBox>().ToList())
            {
                if (listBox.Items.Count != 0)
                {
                    string listBoxName = listBox.Name;
                    string answer = listBox.Items[0].ToString();
                    int index = int.Parse(listBoxName.Substring(6)) - 1;
                    string question = "";
                    bool isCorrect;

                    //If even will call the CallNumbers
                    if (gameAlternatater % 2 == 0)
                    {
                        question = identfiyingAreas.AlternativeDictionary1.ElementAt(index).Key;
                        isCorrect = identfiyingAreas.Validate(question, answer);
                    }
                    //If Odd will call the Descriptions
                    else
                    {
                        question = identfiyingAreas.AlternativeDictionary1.ElementAt(index).Value;
                        isCorrect = identfiyingAreas.Validate(answer, question);
                    }
                    //if Correct will highlight green
                    if (isCorrect)
                    {
                        listBox.ForeColor = Color.DarkGreen;
                        score++;
                    }
                    //if incorrect will highlight Red
                    else
                    {
                        listBox.ForeColor = Color.Red;
                    }
                }
            }
            //Updates Score
            UpdateScore(score);
        }
        #endregion

        #region Clear List Box
        /// <summary>
        /// clears the answer boxes
        /// </summary>
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
        /// <summary>
        /// updates the score of the game
        /// </summary>
        /// <param name="Update"></param>
        private void UpdateScore(int Update)
        {
            Score = Update;
        }
        #endregion

        #region Reset Game
        /// <summary>
        /// Resets The Game
        /// </summary>
        private void ResetGame()
        {
            gameAlternatater = 0;
            totalScore = 0;
            Score = 0;
            CreateQuestion();
        }
        #endregion

        #region Menu Button
        /// <summary>
        /// Method to take you back to Menu Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Take you back to the Menu
            this.Hide();
            Menu HomePage = new Menu();
            HomePage.Show();
        }
        #endregion

        #region Help Button
        /// <summary>
        /// Help Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Resets Progress bar
        /// </summary>
        public void ResetPBBar()
        {
            PBBookGameProgressBar.Value = 0;
        }
        #endregion

        #region Enter
        /// <summary>
        /// Enter Will Update your score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            totalScore += Score;
            lblScoreNumber.Text = Score.ToString();
            lblTotalScoreNumber.Text = totalScore.ToString();
            PBBookGameProgressBar.Increment(Score * 25);
        }
        #endregion

        #region Reset Score
        /// <summary>
        /// Resets Your Score to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetScore_Click(object sender, EventArgs e)
        {
            totalScore = 0;
            Score = 0;
            lblScoreNumber.Text = "0";
            lblTotalScoreNumber.Text = "0";
        }
        #endregion

        #region Next Question
        /// <summary>
        /// Generates another Question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            CreateQuestion();
            ResetPBBar();
        }
        #endregion

    }
}
//-------------------------------------------EndOFFile-----------------------------------------//
