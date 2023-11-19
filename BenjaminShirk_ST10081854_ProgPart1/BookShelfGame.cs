using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ListHandler;

namespace BenjaminShirk_ST10081854_ProgPart1
{
    public partial class BookShelfGame : Form
    {
        //Variables
        public Replacing_Books BooksClass;
        public List<Dewey_Decimal> sList;
        public int Score;
        public int TotalScore;
        System.Timers.Timer timer;
        int h, m, s;
        public BookShelfGame()
        {
            InitializeComponent();
            RefreshPageDetails();
            ListBoxPopulation();
        }

        #region Timer
        //This Functionality was gathered from youtube 
        //https://www.youtube.com/watch?v=0cnM8LypCnA
        /// <summary>
        /// Set Up Of the Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookShelfGame_Load(object sender, EventArgs e)
        {
            //When page loads it will start the timer as well as creation of the timer
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            timer.Start();
        }

        /// <summary>
        /// sets the timer to the text box on time event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtTimer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'),
                    m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        //when form closes it will stop the timer
        private void BookShelfGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }
        #endregion

        #region UpAndDownMovementInListBox
        /// <summary>
        /// Method for up and down in the list box
        /// </summary>
        /// <param name="Movement"></param>
        public void UpAndDownItem(bool Movement)
        {
            try
            {
                //if statement that if the listbox index starts at -1
                if (lstBookList.SelectedIndex == -1) 
                return;

                int Index;
                if (Movement)
                {
                    //if true then the index will -1
                    Index = lstBookList.SelectedIndex - 1;
                }
                else
                {
                    //if false then the index will +1
                    Index = lstBookList.SelectedIndex + 1;
                }
                //if statement that the index is less than or greater than 10
                if (Index < 0 || Index >= 10) 
                return;

                object sItem = lstBookList.SelectedItem;
                lstBookList.Items.Remove(sItem);
                lstBookList.Items.Insert(Index, sItem);
                lstBookList.SetSelected(Index, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region RefreshMethod
        /// <summary>
        /// Refresh the variables and components
        /// </summary>
        public void RefreshPageDetails()
        {
            PBBookGameProgressBar.Value = 0;
            lblScoreNumber.Text = "0";
            btnEnter.Enabled = true;
            lstBookList.Enabled = true;
            lstCorrectSortedList.Items.Clear();
            lstBookList.Items.Clear();
        }
        #endregion

        #region ClearListBox
        /// <summary>
        /// Method to clear ListView
        /// </summary>
        public void ClearListBox()
        {
            //method to clear the listView
            lstCorrectSortedList.Items.Clear();
        }
        #endregion

        #region Verify Lists are in correct order
        /// <summary>
        /// Verify Method to see if list is sorted correctly
        /// </summary>
        public void VerifyCallNumberLists()
        {
            try
            {
                //if statement if their are no books
                if (BooksClass == null)
                return;

                List<Dewey_Decimal> List = new List<Dewey_Decimal>();
                lstCorrectSortedList.Items.Clear();
                int Score = 0;
                //clear List Box
                ClearListBox();

                foreach(var CallNumberBooks in lstBookList.Items)
                {
                    List.Add((Dewey_Decimal)CallNumberBooks);
                }

                //for loop to check if the list and sorted list are the same and giving green for correct and red for worng
                for (int i = 0; i < 10; i++)
                {
                    ListViewItem sListItems = new ListViewItem();
                    sListItems.Text = List[i].ToString();

                    if (List[i] == sList[i])
                    {
                        //change colour to green
                        sListItems.ForeColor = Color.DarkGreen;
                        Score++;      
                    }
                    else
                    {
                        //change colour to red
                        sListItems.ForeColor = Color.Red;
                    }

                    lstCorrectSortedList.Items.Add(sListItems);
                }
                //give the user a score out of 10
                TotalScore += Score;
                lblScoreNumber.Text = Score.ToString();
                lblTotalScoreNumber.Text = TotalScore.ToString();
                //progress bar indicates the percentage you got correct
                PBBookGameProgressBar.Increment(Score * 10);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); 
            }
        }
        #endregion

        #region Enter Button
        /// <summary>
        /// Enter Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Enter Button will call the Verification Method
            lstBookList.SelectedIndex = -1;
            lstBookList.Enabled = false;
            VerifyCallNumberLists();
        }
        #endregion

        #region BackButton
        /// <summary>
        /// Back Button
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

        #region ListBoxPopulation
        /// <summary>
        /// Populates the list boxes with the call numbers
        /// </summary>
        public void ListBoxPopulation()
        {
        BooksClass = new Replacing_Books(); 
        //lstBookList.Items.Clear();

            foreach (var CallNumberBooks in BooksClass.DList) 
            { 
            lstBookList.Items.Add(CallNumberBooks);
            }
            //new sorted list
            sList = new List<Dewey_Decimal>();
            sList = BooksClass.SortedList();
        }
        #endregion

        #region New Game Button
        /// <summary>
        /// Creates a new set of books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            RefreshPageDetails();
            ListBoxPopulation();
        }
        #endregion

        #region Button Up
        /// <summary>
        /// Button Up Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            UpAndDownItem(true);
        }
        #endregion

        #region Button Down
        /// <summary>
        /// Button Down Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            UpAndDownItem(false);
        }
        #endregion

        #region ResetTotalScore
        /// <summary>
        /// Reset Total Score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetTotalScore_Click(object sender, EventArgs e)
        {
            //reset total score
         TotalScore = 0;
         lblTotalScoreNumber.Text = "0";
        }
        #endregion
    }
}
//-------------------------------------------EndOFFile-----------------------------------------//
