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

        private void NewGame()
        {
            timer.Stop();
            timer = new Timer();
            timer.Interval = 1000 / speedLevel;
            timer.Tick += timer_Tick;
            timer.Start();

            score = 0;
            lines = 0;
            statsArr = new int[8];
            for (int i = 1; i < 8; i++)
                UpdateStatsLabel(i);

            lblScore.Text = "SCORE\n0000000";
            lblLines.Text = "LINES - 000";
            lblLevelNum.Text = "0" + speedLevel.ToString();
            lblGameOver.Visible = false;

            matrix = new int[matHeight, matWidth];
            activeShape = new Point[4];
            shapeLanded = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateBoard();
            Draw();
        }

        private void Draw()
        {
            if (!shapeLanded)
            {
                for (int i = 0; i < 4; i++)
                    matrix[activeShape[i].X, activeShape[i].Y] = activeShapeNum;
            }

            Bitmap bitmap = new Bitmap(pbGameBoard.Width, pbGameBoard.Height);
            Graphics gfx = Graphics.FromImage(bitmap);
            SizeF cellSize = new SizeF(pbGameBoard.Width / matWidth, pbGameBoard.Height / matHeight);
            gfx.FillRectangle(Brushes.DimGray, 0, 0, pbGameBoard.Width, pbGameBoard.Height);

            for (int col = 0; col < matWidth; col++)
            {
                for (int row = 0; row < matHeight; row++)
                {
                    Brush cellColour = Brushes.Black;

                    if (matrix[row, col] > 0)
                    {
                        cellColour = Shapes.shapeColours[activeShapeNum];
                        matrix[row, col] = 0;
                    }
                    else if (matrix[row, col] < 0)
                    {
                        cellColour = Shapes.shapeColours[Math.Abs(matrix[row, col])];
                    }

                    gfx.FillRectangle(cellColour, col * cellSize.Width - 1, row * cellSize.Height - 1, cellSize.Width - 1, cellSize.Height - 1);
                }
            }
            pbGameBoard.BackgroundImage = bitmap;
        }





        private void TetrisGame_Load(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
        }
    }
}
