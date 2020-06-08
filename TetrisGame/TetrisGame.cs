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
    public partial class TetrisGame : Form
    {
        public TetrisGame()
        {
            InitializeComponent();
        }

        public static Timer timer = new Timer();
        Random random = new Random();
        Point[] activeShape;
        public static int speedLevel = 1;

        int score;
        int lines;
        int topscore;
        int[,] matrix;
        int matWidth = 10;
        int matHeight = 20;
        int activeShapeNum = 1;
        int nextShape = 1;

        bool shapeLanded = true;
        int[] statsArr = new int[8];

        private void TetrisGame_Load(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
        }
    }
}
