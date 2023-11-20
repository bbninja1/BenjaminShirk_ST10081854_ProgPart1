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
        // Timer Declaration with variables
        System.Timers.Timer timer;
        int h, m, s;
        //-------------------------

        // Data and File Path Variables
        public string[] DataStorage;
        public string PathFile;

        // Red-Black Tree and Display Buttons Variables
        RedBlackTree Tree = new RedBlackTree();
        List<Button> DisplayButtons = new List<Button>();
        List<int> Keys = new List<int>();

        // Game Class and Key Variable
        int Class = 1;
        int mkey = 0;

        // Random Number Generator
        Random random = new Random();

        // Score Tracking Variables
        int Score = 0;
        int TotalScore = 0;
        public FindingCallNumbers()
        {
            InitializeComponent();
            FilePath();
            AddButtons();
            ShuffleButtons(DisplayButtons);
            ReadFileToTree();

            //makes sure the color is white and sets the alignment to the centre
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.ForeColor = Color.White;

            //Set The Progress Bar to 0 on form create
            PBBookGameProgressBar.Value = 0;
        }

        #region File Path
        /// <summary>
        /// Finds the File In the Bin Debug File
        /// </summary>
        public void FilePath()
        {
            //finds the txt file path
            PathFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dewey_Decimal_Data.txt");
            //sets the string array to the data
            DataStorage = File.ReadAllLines(PathFile);
        }
        #endregion

        #region ReadToTree
        /// <summary>
        /// Reads data from a file and populates a tree.
        /// </summary>
        public void ReadFileToTree()
        {
            // Iterates through each data string in the Data collection
            foreach (string dataString in DataStorage)
            {
                // Split the data string into two parts using the dot as a separator
                string[] split = dataString.Split('.');

                // Check if the split results in exactly two parts, and if the first part can be parsed as an integer
                if (split.Length == 2 && int.TryParse(split[0], out int data))
                {
                    // Extracts the description from the second part and insert the data and description into the tree
                    string description = split[1];
                    Tree.Insert(data, description);
                }
                else
                {
                    // Display an error message for improperly formatted data
                    Console.WriteLine("Error: " + dataString);
                }
            }

            // Call Generate Description
            GenerateDescription();

            // Find a node based on the generated key and update the first button
            Node bNode = Tree.Find(int.Parse(mkey.ToString()[0] + "00"));
            DisplayButtons.First().Text = $"{bNode.data}, {bNode.desc.Replace("&", "&&")}";
            DisplayButtons.RemoveAt(0);
            Keys.Add(bNode.data);

            // Display values on buttons
            ButtonDisplay(DisplayButtons, 3);
        }

        /// <summary>
        /// Generates a description and updates UI.
        /// </summary>
        private void GenerateDescription()
        {
            Node tNode = null;
            int num = -1;

            // Generate a random number within a specified range until a valid node is found
            while (tNode == null)
            {
                //numbers in which my data can be found
                num = random.Next(110, 577);

                // Ensure that the generated number is not a multiple of 10
                if (num % 10 != 0)
                {
                    // Find a node with the generated number as the key
                    tNode = Tree.Find(num);
                    mkey = num;
                }
            }

            // Update the description label with the description
            lblDescription.Text = tNode.desc.Replace("&", "&&");
        }
        #endregion

        #region Classes
        /// <summary>
        /// Generates nodes for the top Class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="uKeys"></param>
        private List<Node> TClass(int count, List<int> uKeys)
        {
            return GenerateLevel(count, uKeys, 100, 600, k => k % 100 == 0);
        }

        /// <summary>
        /// Generates second Class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="uKeys"></param>
        private List<Node> SClass(int count, List<int> uKeys)
        {
            string cStart = mkey.ToString()[0].ToString();
            return GenerateLevel(count, uKeys, 10, 96, k => k % 10 == 0, cStart);
        }

        /// <summary>
        /// Generates third Class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="uKeys"></param>
        
        private List<Node> ThirdClass(int count, List<int> uKeys)
        {
            string cStart = mkey.ToString().Substring(0, 2);
            return GenerateLevel(count, uKeys, 1, 9, k => !uKeys.Contains(k), cStart);
        }

        /// <summary>
        /// Generates nodes for a specific level
        /// </summary>
        /// <param name="count"></param>
        /// <param name="uKeys"></param>
        /// <param name="minRange"></param>
        /// <param name="maxRange"></param>
        /// <param name="condition"></param>
        /// <param name="prefix"></param>
        private List<Node> GenerateLevel(int count, List<int> uKeys, int min, int max, Func<int, bool> condition, string prefix = "")
        {
            List<Node> levelNode = new List<Node>();

            for (int i = 0; i < count; i++)
            {
                Node tNode = null;
                int k = -1;

                while (tNode == null)
                {
                    //Generate a key within the specified range and prefix
                    k = int.Parse($"{prefix}{random.Next(min, max)}");

                    //key meets the specified condition
                    if (condition(k))
                    {
                        tNode = Tree.Find(k);
                    }
                }

                //Add the generated node and key to the list
                levelNode.Add(tNode);
                uKeys.Add(k);
            }

            return levelNode;
        }
        #endregion

        #region Button Display

        /// <summary>
        /// Displays values on the provided buttons based on the given node class.
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="count"></param>
        /// <param name="tClassNode"></param>
        private void DisplayClass(List<Button> buttons, int count, List<Node> tClassNode)
        {
            for (int i = 0; i < count; i++)
            {
                // Checks if the index is within the range of the buttons and if the corresponding node is not null
                if (i < buttons.Count && tClassNode[i] != null)
                {
                    
                    buttons[i].Text = $"{tClassNode[i].data}, {tClassNode[i].desc.Replace("&", "&&")}";
                }
                else
                {
                    // Default Text
                    buttons[i].Text = "Description";
                }
            }
        }

        /// <summary>
        /// Displays button values for the first level.
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="count"></param>
        public void ButtonDisplay(List<Button> buttons, int count)
        {
            // Gets the values for the buttons based on the first level
            DisplayClass(buttons, count, TClass(count, Keys));
        }

        /// <summary>
        /// Displays button values for the second level.
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="count"></param>
        public void ButtonDisplay2(List<Button> buttons, int count)
        {
            // Gets the values for the buttons based on the second level
            DisplayClass(buttons, count, SClass(count, Keys));
        }

        /// <summary>
        /// Displays button values for the third level.
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="count"></param>
        public void ButtonDisplay3(List<Button> buttons, int count)
        {
            // Gets the values for the buttons based on the third level
            DisplayClass(buttons, count, ThirdClass(count, Keys));
        }
        #endregion

        #region Shuffle Buttons
        /// <summary>
        /// Shuffles the order of buttons randomly.
        /// </summary>
        /// <param name="buttons"></param>
        public void ShuffleButtons(List<Button> buttons)
        {
            // Gest the total number of buttons
            int numberOfButtons = buttons.Count;

            // Loops through the buttons and shuffles their order
            while (numberOfButtons > 1)
            {
                numberOfButtons--;

                // Generate a random index within the remaining buttons
                int randomIndex = random.Next(numberOfButtons + 1);

                // Swap the positions of the current button and a randomly chosen button
                Button temp = buttons[randomIndex];
                buttons[randomIndex] = buttons[numberOfButtons];
                buttons[numberOfButtons] = temp;
            }
        }
        #endregion

        #region Assign Button Values
        /// <summary>
        /// Assigns values to buttons based on the first and second digits of the current key.
        /// </summary>
        public void AssignButtonValues()
        {
            //Initialize the node to null
            Node bNode = null;

            //Extracts the first two digits and append '0' to form the key for level 1
            int cLevelKey = int.Parse($"{mkey.ToString()[0]}{mkey.ToString()[1]}0");

            //Finds the node in the tree with the calculated key
            bNode = Tree.Find(cLevelKey);

            //If the node is found, update the text of the first button, remove it, and add the key to the list
            if (bNode != null)
            {
                DisplayButtons[0].Text = $"{bNode.data}, {bNode.desc}";
                DisplayButtons.RemoveAt(0);
                Keys.Add(cLevelKey);
            }
        }

        /// <summary>
        /// Assigns values to buttons based on the current key.
        /// </summary>
        public void AssignButtonValue1()
        {
            //Initializes the node to null
            Node bNode = null;

            //Finds the node in the tree with the current key
            bNode = Tree.Find(mkey);

            //If the node is found, update the text of the first button, remove it, and add the key to the list
            if (bNode != null)
            {
                DisplayButtons[0].Text = $"{bNode.data}, {bNode.desc}";
                DisplayButtons.RemoveAt(0);
                Keys.Add(mkey);
            }
        }
        #endregion

        #region Button Clicks
        /// <summary>
        /// Handles the click event for answer buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerButtonClick(object sender, EventArgs e)
        {
            //Checks if the current class is 1
            if (Class == 1)
            {
                //sender as a Button
                Button clickedButton = (Button)sender;

                // Check conditions based on the text of the clicked button
                if (Validation(clickedButton.Text.ToString()))
                {
                    //move to level 2 and update progress bar
                    Class2();
                    PBBookGameProgressBar.Value = 25;
                }
                //Checks if the current class is 2
                else if (Class == 2)
                {
                    if (Validation2(clickedButton.Text.ToString()))
                    {
                        //move to level 3 and update progress bar
                        Class3();
                        PBBookGameProgressBar.Value = 50;
                    }
                }
                //Checks if the current class is 3
                else if (Class == 3)
                {
                    if (Validation3(clickedButton.Text.ToString()))
                    {
                        //show results, update progress bar, and scores
                        Results();
                        PBBookGameProgressBar.Value = 100;
                        Score++;
                        TotalScore += Score;
                        UpdateScore();
                    }
                }
            }
        }
        /// <summary>
        /// Event handler for the first answer button click.
        /// </summary>
        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            AnswerButtonClick(sender, e);
        }
        /// <summary>
        /// Event handler for the second answer button click.
        /// </summary>
        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            AnswerButtonClick(sender, e);
        }
        /// <summary>
        /// Event handler for the third answer button click.
        /// </summary>
        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            AnswerButtonClick(sender, e);
        }
        /// <summary>
        /// Event handler for the fourth answer button click.
        /// </summary>
        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            AnswerButtonClick(sender, e);
        }
        #endregion

        #region Validation
        /// <summary>
        /// Checks if the first digit of the current key matches the first character of the provided text.
        /// </summary>
        /// <param name="txt"></param>
        public bool Validation(string txt)
        {
            if (mkey.ToString()[0] == txt[0])
            {
                return true;
            }
            else
            {
                // If the check fails, show an invalid result and return false
                InvalidResult();
                return false;
            }
        }

        /// <summary>
        /// Checks if the first two digits of the current key match the first two characters of the provided text.
        /// </summary>
        /// <param name="txt"></param>
        public bool Validation2(string txt)
        {
            if (mkey.ToString().Substring(0, 2) == txt.Substring(0, 2))
            {
                return true;
            }
            else
            {
                // If the check fails, show an invalid result and return false
                InvalidResult();
                return false;
            }
        }

        /// <summary>
        /// Checks if the entire current key matches the first three characters of the provided text.
        /// </summary>
        /// <param name="txt"></param>

        public bool Validation3(string txt)
        {
            if (mkey.ToString() == txt.Substring(0, 3))
            {
                return true;
            }
            else
            {
                //If the check fails, show an invalid result and return false
                InvalidResult();
                return false;
            }
        }
        #endregion

        #region SetUpClass
        /// <summary>
        /// Class display as we go through the hierachy
        /// </summary>
        //Class 2 Set Up Values and Shuffle Buttons
        public void Class2()
        {
            DisplayButtons.Clear();
            AddButtons();
            ShuffleButtons(DisplayButtons);
            AssignButtonValues();
            ButtonDisplay2(DisplayButtons, 3);
            Class = 2;
        }

        //Class 3 Set Up Values and Shuffle Buttons
        public void Class3()
        {
            DisplayButtons.Clear();
            AddButtons();
            ShuffleButtons(DisplayButtons);
            AssignButtonValue1();
            ButtonDisplay3(DisplayButtons, 3);
            Class = 3;
        }
        #endregion

        #region Check Results
        /// <summary>
        /// Method that holds messages whether the user is correct or incorrect
        /// </summary>
        
        //Positive Result
        public void Results()
        {
            MessageBox.Show("Well Done you have successfully completed the game");
        }

        //Negative Result
        public void InvalidResult()
        {
            MessageBox.Show("Incorrect Answer you have unsuccessfully completed the game");
        }

        #endregion

        #region Add Buttons
        /// <summary>
        /// Adds Buttons To List of Buttons
        /// </summary>
        public void AddButtons()
        {
            //Adding buttons to the list
            DisplayButtons.Add(btnAnswer1);
            DisplayButtons.Add(btnAnswer2);
            DisplayButtons.Add(btnAnswer3);
            DisplayButtons.Add(btnAnswer4);
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
        /// <summary>
        /// Button click to go back to the main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MainMenu = new Menu();
            MainMenu.Show();
        }
        #endregion

        #region Update Score
        /// <summary>
        /// Update Score Method
        /// </summary>
        public void UpdateScore()
        {
            lblScoreNumber.Text = Score.ToString();
            lblTotalScoreNumber.Text = TotalScore.ToString();
        }
        #endregion

        #region Reset Score
        /// <summary>
        /// Resets the score and Labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetScore_Click(object sender, EventArgs e)
        {
            TotalScore = 0;
            Score = 0;
            lblScoreNumber.Text = "0";
            lblTotalScoreNumber.Text = "0";
            //Message to reset your score
            MessageBox.Show("You have reset your Scores");
        }
        #endregion

        #region New Game
        /// <summary>
        /// New Game Click that will re-start the form to generate a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            FindingCallNumbers findingCallNumbers = new FindingCallNumbers();
            findingCallNumbers.FormClosing += FindingCallNumbers_FormClosing;
            this.Hide();
            findingCallNumbers.Show();
        }

        #endregion
    }
}
//-------------------------------------------EndOFFile-----------------------------------------//