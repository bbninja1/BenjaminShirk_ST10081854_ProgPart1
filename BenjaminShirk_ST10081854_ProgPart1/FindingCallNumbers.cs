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

namespace BenjaminShirk_ST10081854_ProgPart1
{
    public partial class FindingCallNumbers : Form
    {
        System.Timers.Timer timer;
        int h, m, s;

        #region Timer
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
