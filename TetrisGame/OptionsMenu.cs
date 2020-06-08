using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class OptionsMenu : Form
    {
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void btnSpeedDec_Click(object sender, EventArgs e)
        {
            if (TetrisGame.speedLevel > 1) TetrisGame.speedLevel--;
            lblSpeedTotal.Text = TetrisGame.speedLevel.ToString();
        }

        private void btnSpeedInc_Click(object sender, EventArgs e)
        {
            if (TetrisGame.speedLevel < 10) TetrisGame.speedLevel++;
            lblSpeedTotal.Text = TetrisGame.speedLevel.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {
            lblSpeedTotal.Text = TetrisGame.speedLevel.ToString();
            TetrisGame.timer.Stop();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
