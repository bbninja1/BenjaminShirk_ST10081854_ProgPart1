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
    public partial class IdentifyingAreas : Form
    {
        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        #region Menu Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Take you back to the Menu
            this.Hide();
            Menu HomePage = new Menu();
            HomePage.Show();
        }
        #endregion

    }
}
