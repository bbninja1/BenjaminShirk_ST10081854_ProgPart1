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

        #region StartGame Button
        /// <summary>
        /// StartGame application button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
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
            this.Hide();
            Identifying_Areas_Game identifyingAreas = new Identifying_Areas_Game();
            identifyingAreas.Show();
        }

        #endregion

        #region FindingCallNumbers
        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindingCallNumbers FindingCall = new FindingCallNumbers();
            FindingCall.Show();
        }
        #endregion
    }
}
//-------------------------------------------EndOFFile-----------------------------------------//