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
    public partial class FindingCallNumbers : Form
    {
        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        #region Menu Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MainMenu = new Menu();
            MainMenu.Show();
        }
        #endregion
    }
}
