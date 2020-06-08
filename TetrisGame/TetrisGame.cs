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

        private void UpdateBoard()
        {
            if (shapeLanded)
            {
                checkLines();
                PlaceShape(Shapes.shapeList[nextShape]);
                shapeLanded = false;
            }
            else
            {
                if (activeShape.Count(b => b.X >= matHeight - 1 || matrix[b.X + 1, b.Y] < 0) > 0)
                    shapeLanded = true;

                for (int i = 0; i < 4; i++)
                {
                    if (shapeLanded)
                        matrix[activeShape[i].X, activeShape[i].Y] = -activeShapeNum;
                    else
                        activeShape[i].X++;
                }
            }
        }
        private void PlaceShape(Point[] inputShape)
        {
            activeShapeNum = nextShape;
            activeShape = inputShape.Select(x => x).ToArray();

            for (int i = 0; i < 4; i++)
            {
                if (matrix[activeShape[i].X, activeShape[i].Y] != 0)
                    GameOver();
            }

            statsArr[activeShapeNum]++;
            UpdateStatsLabel(activeShapeNum);

            nextShape = random.Next(1, 8);

            pbNextShape.BackgroundImage = Shapes.shapeImages[nextShape];
        }

        private void checkLines()
        {
            int linecount = 0;
            var rowsToCheck = activeShape.Select(x => x.X).Distinct().OrderBy(x => x).ToArray();

            for (int i = 0; i < rowsToCheck.Count(); i++)
            {
                bool line = true;

                for (int e = 0; e < matWidth; e++)
                {
                    if (matrix[rowsToCheck[i], e] == 0)
                    {
                        line = false;
                        break;
                    }
                }
                if (line)
                {
                    linecount++;

                    for (int d = rowsToCheck[i]; d > 0; d--)
                    {
                        for (int m = 0; m < matWidth; m++)
                            matrix[d, m] = matrix[d - 1, m];
                    }
                }
            }

            if (linecount > 0)
            {
                lines += linecount;
                lblLines.Text = "LINES - " + new string('0', 3 - lines.ToString().Length) + lines;

                score += CalculateScore(linecount, speedLevel);
                lblScore.Text = "SCORE" + "\n" + new string('0', 7 - score.ToString().Length) + score;

                if ((lines / 10) > speedLevel) speedLevel = lines / 10;

                timer.Interval = 1000 / speedLevel;
                lblLevelNum.Text = "0" + speedLevel.ToString();
            }
        }

        private void GameOver()
        {
            timer.Stop();
            string topScore = "";
            speedLevel = 1;

            if (score > topscore)
            {
                topScore = "You got a new\n top score!";
                topscore = score;
                lblTopScore.Text = "TOP  \n" + new string('0', 7 - score.ToString().Length) + score.ToString() + topscore;
            }

            lblGameOver.Text = "GAME OVER!" + "\n" + topScore;
            lblGameOver.Visible = true;
        }

        private int CalculateScore(int lines, int level)
        {
            if (lines == 1) return 40 * level;
            else if (lines == 2) return 100 * level;
            else if (lines == 3) return 300 * level;
            else return 1200 * level;
        }

        private void TetrisGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    if (timer.Enabled)
                    {
                        timer.Stop();
                        lblGameOver.Text = "PAUSED";
                        lblGameOver.Visible = true;
                    }
                    else
                    {
                        timer.Start();
                        lblGameOver.Visible = false;
                    }
                    break;
                case Keys.Enter:
                    NewGame();
                    break;
            }

            if (timer.Enabled)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        try
                        {
                            if (activeShape.Where(b => matrix[b.X, b.Y - 1] < 0 || b.Y - 1 < 0).Count() == 0)
                                activeShape = activeShape.Select(b => new Point(b.X, b.Y - 1)).ToArray();
                        }
                        catch (IndexOutOfRangeException) { }
                        break;
                    case Keys.Right:
                        try
                        {
                            if (activeShape.Where(b => matrix[b.X, b.Y + 1] < 0 || b.Y + 1 < 0).Count() == 0)
                                activeShape = activeShape.Select(b => new Point(b.X, b.Y + 1)).ToArray();
                        }
                        catch (IndexOutOfRangeException) { }
                        break;
                    case Keys.Down:
                        try
                        {
                            if (activeShape.Where(b => matrix[b.X + 1, b.Y] < 0 || b.X + 1 > matHeight - 1).Count() == 0)
                            {
                                activeShape = activeShape.Select(b => new Point(b.X + 1, b.Y)).ToArray();
                                score++;
                                lblScore.Text = "SCORE" + "\n" + new string('0', 7 - score.ToString().Length) + score.ToString();
                            }
                        }
                        catch (IndexOutOfRangeException) { }
                        break;
                    case Keys.Up:
                        activeShape = Rotate(activeShape);
                        break;
                }
            }
        }

        private Point[] Rotate(Point[] inputShape)
        {
            Point[] res = new Point[4];

            int pivotX = inputShape[0].X;
            int pivotY = inputShape[0].Y;

            for (int i = 0; i < 4; i++)
            {
                int satX = inputShape[i].X - pivotX;
                int satY = inputShape[i].Y - pivotY;

                res[i].X = (0 * satX) + (-1 * satY) + pivotX;
                res[i].Y = (1 * satX) + (0 * satY) + pivotY;
            }

            if (res.Count(b => b.Y < 0 || b.Y > matWidth - 1 || b.X > matHeight - 1 || matrix[b.X, b.Y] < 0) == 0)
                return res;
            else
                return inputShape;
        }

        private void TetrisGame_Load(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;

            pbStatsI.BackgroundImage = Shapes.shapeImages[1];
            pbStatsJ.BackgroundImage = Shapes.shapeImages[2];
            pbStatsL.BackgroundImage = Shapes.shapeImages[3];
            pbStatsO.BackgroundImage = Shapes.shapeImages[4];
            pbStatsS.BackgroundImage = Shapes.shapeImages[5];
            pbStatsT.BackgroundImage = Shapes.shapeImages[6];
            pbStatsZ.BackgroundImage = Shapes.shapeImages[7];
        }

        private void UpdateStatsLabel(int label)
        {
            if (label == 1) lblStatsI.Text = "x   " + statsArr[label];
            else if (label == 2) lblStatsJ.Text = "x   " + statsArr[label];
            else if (label == 3) lblStatsL.Text = "x   " + statsArr[label];
            else if (label == 4) lblStatsO.Text = "x   " + statsArr[label];
            else if (label == 5) lblStatsS.Text = "x   " + statsArr[label];
            else if (label == 6) lblStatsT.Text = "x   " + statsArr[label];
            else if (label == 7) lblStatsZ.Text = "x   " + statsArr[label];
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
