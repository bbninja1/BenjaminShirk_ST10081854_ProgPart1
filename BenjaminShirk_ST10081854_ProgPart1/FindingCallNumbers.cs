using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static BenjaminShirk_ST10081854_ProgPart1.RedBlackTree;

namespace BenjaminShirk_ST10081854_ProgPart1
{
    public partial class FindingCallNumbers : Form
    {
        //Timer Decleration with variables
        System.Timers.Timer timer;
        int h, m, s;
        //-------------------------//
        private string[] Data;
        private string PFile;
        RedBlackTree Tree = new RedBlackTree();
        List<Button> DisplayButtons = new List<Button>();
        List<int> Keys = new List<int>();
        int level = 1;
        int mkey = 0;
        Random random = new Random();
        int Score = 0;
        int TotalScore = 0;

        public FindingCallNumbers()
        {
            InitializeComponent();
            PFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dewey_Decimal_Data.txt");
            Data = File.ReadAllLines(PFile);

            AddButtons();
            SchuffleButtons(DisplayButtons);
            ReadFileToTree();
            
        }

        #region Add Buttons
        public void AddButtons()
        {
            DisplayButtons.Add(btnAnswer1);
            DisplayButtons.Add(btnAnswer2);
            DisplayButtons.Add(btnAnswer3);
            DisplayButtons.Add(btnAnswer4);
        }
        #endregion

        #region ReadToTree
        public void ReadFileToTree()
        {
            foreach(string Data in Data)
            {
                string[] split = Data.Split('.');

                if (split.Length == 2 && int.TryParse(split[0],out int data))
                {
                    string description = split[1];
                    Tree.Insert(data, description);
                }
                else
                {
                    Console.WriteLine("Error" + Data);
                }
            }

            Node tNode = null;
            int num = -1;

            while (tNode == null) 
            {
                num = random.Next(110,577);

                if (num % 10 != 0)
                {
                    tNode = Tree.Find(num);
                    mkey = num;
                }
            }

            lblDescription.Text = tNode.desc.Replace("&", "&&");

            Node bNode = null;
            bNode = Tree.Find(int.Parse(num.ToString()[0] + "00"));

            DisplayButtons.First().Text = bNode.data.ToString() + ", " + bNode.desc.Replace("&","&&");
            DisplayButtons.Remove(DisplayButtons[0]);
            Keys.Add(bNode.data);

            lblDescription.Text = tNode.desc.Replace("&", "&&");
            ButtonDisplay(DisplayButtons, 3);

        }
        #endregion

        #region TopLevel
        private List<Node> TLevel(int count, List<int> uKeys)
        {
            List<Node> tLevelNode = new List<Node>();

            for (int i = 0; i < count; i++)
            {
                Node tNode = null;
                int k = -1;

                while (tNode == null)
                {
                    k = random.Next(100, 501);


                    if (k % 100 == 0 && !Keys.Contains(k))
                    {
                        tNode = Tree.Find(k);
                    }
                }
                tLevelNode.Add(tNode);
                uKeys.Add(k);

            }

            return tLevelNode;
        }
        #endregion

        #region SecondLevel
        private List<Node> SLevel(int count, List<int> uKeys)
        {
            List<Node> sLevelNode = new List<Node>();

            string cStart = mkey.ToString()[0].ToString();

            for (int i = 0; i < count; i++)
            {
                Node tNode = null;
                int k = -1;

                while (tNode == null)
                {
                    k = int.Parse($"{cStart}{random.Next(10, 96)}");    

                    if (k % 10 == 0 && !Keys.Contains(k))
                    {
                        tNode = Tree.Find(k);
                    }
                }
                sLevelNode.Add(tNode);
                uKeys.Add(k);

            }

            return sLevelNode;
        }
        #endregion

        #region ThirdLevel
        private List<Node> ThirdLevel(int count, List<int> uKeys)
        {
            List<Node> TLevelNode = new List<Node>();

            string cStart = mkey.ToString().Substring(0,2);

            for (int i = 0; i < count; i++)
            {
                Node tNode = null;
                int k = -1;

                while (tNode == null)
                {
                    k = int.Parse($"{cStart}{random.Next(1, 9)}");

                    if (!uKeys.Contains(k))
                    {
                        tNode = Tree.Find(k);
                    }
                }
                TLevelNode.Add(tNode);
                uKeys.Add(k);

            }

            return TLevelNode;
        }

        #endregion

        #region Button Display
        public void ButtonDisplay(List<Button> buttons, int count)
        {
            List<Node> tLevelNode = TLevel(count, Keys);

            for (int i = 0;i < count;i++) 
            {
                if (i < buttons.Count && tLevelNode[i] != null)
                {
                    buttons[i].Text = tLevelNode[i].data.ToString() + ", " + tLevelNode[i].desc.Replace("&", "&&");
                }
                else
                {
                    buttons[i].Text = "Description";
                }
            }
        }

        public void ButtonDisplay2(List<Button> buttons, int count)
        {
            List<Node> tLevelNode = SLevel(count, Keys);

            for (int i = 0; i < count; i++)
            {
                if (i < buttons.Count && tLevelNode[i] != null)
                {
                    buttons[i].Text = tLevelNode[i].data.ToString() + ", " + tLevelNode[i].desc.Replace("&", "&&");
                }
                else
                {
                    buttons[i].Text = "Description";
                }
            }
        }

        public void ButtonDisplay3(List<Button> buttons, int count)
        {
            List<Node> tLevelNode = ThirdLevel(count, Keys);

            for (int i = 0; i < count; i++)
            {
                if (i < buttons.Count && tLevelNode[i] != null)
                {
                    buttons[i].Text = tLevelNode[i].data.ToString() + ", " + tLevelNode[i].desc.Replace("&", "&&");
                }
                else
                {
                    buttons[i].Text = "Description";
                }
            }
        }

        #endregion

        #region Schuffle Buttons
        public void SchuffleButtons(List<Button>b)
        {
            int n = b.Count;
            while (n > 1)
            {
                n--;
                int j = random.Next(n+1);
                Button temp = b[j];
                b[j] = b[n];
                b[n] = temp;

            }
        }
        #endregion

        #region AssignButtonValues
        public void assignButtonValues()
        {
            Node bNode = null;
            int cLevelKey = int.Parse($"{mkey.ToString()[0]}{mkey.ToString()[1]}0");
            bNode = Tree.Find(cLevelKey);
            if (bNode != null)
            {
                DisplayButtons[0].Text = bNode.data.ToString() + ", " + bNode.desc;
                DisplayButtons.RemoveAt(0);
                Keys.Add(cLevelKey);
            }
        }

        public void assignButtonValue1()
        {
            Node bNode = null;
            bNode = Tree.Find(mkey);
            if (bNode != null)
            {
                DisplayButtons[0].Text = bNode.data.ToString() + ", " + bNode.desc;
                DisplayButtons.RemoveAt(0);
                Keys.Add(mkey);
            }
        }
        #endregion

        #region Button Clicks
        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (checkButton(btnAnswer1.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 25;
                    lvl2();
                }
                else if (checkButton2(btnAnswer1.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 50;
                    lvl3();
                }
                else if (checkButton3(btnAnswer1.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 100;
                    Score = Score + 1;
                    TotalScore = TotalScore + Score;
                    Results();
                    UpdateScore();
                }
            }
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (checkButton(btnAnswer2.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 25;
                    lvl2();
                }
                else if (checkButton2(btnAnswer2.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 50;
                    lvl3();
                }
                else if (checkButton3(btnAnswer2.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 100;
                    Score = Score + 1;
                    TotalScore = TotalScore + Score;
                    Results();
                    UpdateScore();
                }
            }
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (checkButton(btnAnswer3.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 25;
                    lvl2();
                }
                else if (checkButton2(btnAnswer3.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 50;
                    lvl3();

                }
                else if (checkButton3(btnAnswer3.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 100;
                    Score = Score + 1;
                    TotalScore = TotalScore + Score;
                    Results();
                    UpdateScore();
                }
            }
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (checkButton(btnAnswer4.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 25;
                    lvl2();
                }
                else if (checkButton2(btnAnswer4.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 50;
                    lvl3();
                }
                else if (checkButton3(btnAnswer4.Text.ToString()))
                {
                    PBBookGameProgressBar.Value = 100;
                    Score = Score + 1;
                    TotalScore = TotalScore + Score;
                    Results();
                    UpdateScore();
                }
            }
        }
        #endregion

        #region ButtonCheck
        public bool checkButton(string txt)
        {
            if (mkey.ToString()[0] == txt[0])
            {
                return true;
            }
            else
            {
                InvalidResult();
                return false;
            }
        }

        public bool checkButton2(string txt)
        {
            if (mkey.ToString().Substring(0,2) == txt.Substring(0, 2))
            {
                return true;
            }
            else
            {
                InvalidResult();
                return false;
            }
        }

        public bool checkButton3(string txt) 
        {
            if (mkey.ToString() == txt.Substring(0, 3))
            {
                return true;
            }
            else
            {
                InvalidResult();
                return false;
            }

        }
        #endregion

        #region Check Results

        public void Results()
        {
            MessageBox.Show("Well Done you have successfully completed the game");
        }

        public void InvalidResult()
        {
            MessageBox.Show("Incorrect Answer you have unsuccessfully completed the game");
        }

        #endregion

        #region SetUpLevel

        public void lvl2()
        {
            DisplayButtons.Clear();
            AddButtons();
            SchuffleButtons(DisplayButtons);
            assignButtonValues();
            ButtonDisplay2(DisplayButtons, 3);
            level = 2;
        }

        public void lvl3()
        {
            DisplayButtons.Clear();
            AddButtons();
            SchuffleButtons(DisplayButtons);
            assignButtonValue1();
            ButtonDisplay3(DisplayButtons, 3);
            level = 3;
        }
        #endregion

        #region Timer
        //This Functionality was gathered from youtube 
        //https://www.youtube.com/watch?v=0cnM8LypCnA
        /// <summary>
        /// Set Up Of the Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindingCallNumbers_Load(object sender, EventArgs e)
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
        private void FindingCallNumbers_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        #endregion

        #region Menu Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MainMenu = new Menu();
            MainMenu.Show();
        }
        #endregion

        #region Update Score

        public void UpdateScore()
        {
            lblScoreNumber.Text = Score.ToString();
            lblTotalScoreNumber.Text = TotalScore.ToString();
        }
        #endregion

        #region Reset Score
        private void btnResetScore_Click(object sender, EventArgs e)
        {
            TotalScore = 0;
            Score = 0;
            lblScoreNumber.Text = "0";
            lblTotalScoreNumber.Text = "0";
        }
        #endregion
    }
}
