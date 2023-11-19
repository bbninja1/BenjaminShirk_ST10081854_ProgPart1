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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        #region BookShelfGame
        /// <summary>
        /// StartGame application button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            DisplayMessageBookShelf();
            //open the game form
            this.Hide();
            BookShelfGame bookShelfGame = new BookShelfGame();
            bookShelfGame.Show();
        }
        #endregion

        #region Close Button
        /// <summary>
        /// Close application Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Exit the application
            this.Close();
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
            //Help message for user
            MessageBox.Show("Welcome to the Help Center of BookMania!\n\n" +
                           "BookMania currently is a book ordering game\n" +
                           "If you would like to play our game,'Book Order' please click the start game button\n\n" +
                           "Please have fun and enjoy!",
                           "BookMania",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

        }
        #endregion

        #region IdentifyingAreasGame
        /// <summary>
        /// StartGame application button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            DisplayMessageIdentifyingAreas();
            this.Hide();
            Identifying_Areas_Game identifyingAreas = new Identifying_Areas_Game();
            identifyingAreas.Show();
        }

        #endregion

        #region FindingCallNumbers
        /// <summary>
        /// StartGame application button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            DisplayMessageFindingCallNumbers();
            this.Hide();
            FindingCallNumbers FindingCall = new FindingCallNumbers();
            FindingCall.Show();
        }
        #endregion

        #region DisplayMessages
        /// <summary>
        /// Display Messages
        /// </summary>
        //BookShelf Game Message
        public void DisplayMessageBookShelf()
        {
            MessageBox.Show("Welcome to the BookShelfGame!\n\n" +
                              "BookShelfGame\n" +
                              "Bookshelf game is a organising game where you are to required to order the callnumbers in ascending order\n\n" +
                              "Please have fun and enjoy!",
                              "BookMania",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
        }
        //IdentifyingArea Game Message
        public void DisplayMessageIdentifyingAreas()
        {
            MessageBox.Show("Welcome to the Indentifying Areas!\n\n" +
                            "Indentifying Areas\n" +
                            "Identifying Areas is a column matching game where you are to match the callnumber with the description\n\n" +
                            "Please have fun and enjoy!",
                            "BookMania",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        //FindingCallNumbers Game Message
        public void DisplayMessageFindingCallNumbers()
        {
            MessageBox.Show("Welcome to the FindingCallNumbers!\n\n" +
                          "FindingCallNumbers\n" +
                          "FindingCallNumbers is a  drills deeper and deeper into the hierarchy until they find the correct answer\n\n" +
                          "Please have fun and enjoy!",
                          "BookMania",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
        #endregion
    }
}
//-------------------------------------------EndOFFile-----------------------------------------//