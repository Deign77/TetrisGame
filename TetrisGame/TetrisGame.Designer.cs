namespace TetrisGame
{
    partial class TetrisGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGameBoard = new System.Windows.Forms.PictureBox();
            this.lblTopScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbNextShape = new System.Windows.Forms.PictureBox();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblLevelNum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbStatsI = new System.Windows.Forms.PictureBox();
            this.pbStatsJ = new System.Windows.Forms.PictureBox();
            this.pbStatsL = new System.Windows.Forms.PictureBox();
            this.pbStatsO = new System.Windows.Forms.PictureBox();
            this.pbStatsS = new System.Windows.Forms.PictureBox();
            this.pbStatsT = new System.Windows.Forms.PictureBox();
            this.pbStatsZ = new System.Windows.Forms.PictureBox();
            this.lblStatsI = new System.Windows.Forms.Label();
            this.lblStatsZ = new System.Windows.Forms.Label();
            this.lblStatsT = new System.Windows.Forms.Label();
            this.lblStatsS = new System.Windows.Forms.Label();
            this.lblStatsO = new System.Windows.Forms.Label();
            this.lblStatsL = new System.Windows.Forms.Label();
            this.lblStatsJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextShape)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsZ)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameBoard
            // 
            this.pbGameBoard.BackColor = System.Drawing.Color.Black;
            this.pbGameBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGameBoard.Location = new System.Drawing.Point(245, 85);
            this.pbGameBoard.Name = "pbGameBoard";
            this.pbGameBoard.Size = new System.Drawing.Size(400, 800);
            this.pbGameBoard.TabIndex = 0;
            this.pbGameBoard.TabStop = false;
            // 
            // lblTopScore
            // 
            this.lblTopScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTopScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTopScore.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopScore.ForeColor = System.Drawing.Color.White;
            this.lblTopScore.Location = new System.Drawing.Point(681, 85);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(150, 68);
            this.lblTopScore.TabIndex = 1;
            this.lblTopScore.Text = "TOP 0000000";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(681, 168);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(150, 68);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "SCORE     0000000";
            // 
            // pbNextShape
            // 
            this.pbNextShape.BackColor = System.Drawing.Color.Black;
            this.pbNextShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbNextShape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbNextShape.Location = new System.Drawing.Point(681, 332);
            this.pbNextShape.Name = "pbNextShape";
            this.pbNextShape.Size = new System.Drawing.Size(150, 171);
            this.pbNextShape.TabIndex = 3;
            this.pbNextShape.TabStop = false;
            // 
            // lblLines
            // 
            this.lblLines.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLines.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLines.ForeColor = System.Drawing.Color.White;
            this.lblLines.Location = new System.Drawing.Point(360, 38);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(179, 35);
            this.lblLines.TabIndex = 5;
            this.lblLines.Text = "LINES - 000";
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.Black;
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLevel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(704, 596);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(99, 68);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "LEVEL";
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Black;
            this.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGameOver.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(321, 371);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(245, 47);
            this.lblGameOver.TabIndex = 10;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatistics
            // 
            this.lblStatistics.BackColor = System.Drawing.Color.Black;
            this.lblStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatistics.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.ForeColor = System.Drawing.Color.White;
            this.lblStatistics.Location = new System.Drawing.Point(24, 124);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(200, 516);
            this.lblStatistics.TabIndex = 7;
            this.lblStatistics.Text = "STATISTICS";
            this.lblStatistics.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNext
            // 
            this.lblNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNext.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(713, 294);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(90, 35);
            this.lblNext.TabIndex = 6;
            this.lblNext.Text = "NEXT";
            // 
            // lblLevelNum
            // 
            this.lblLevelNum.AutoSize = true;
            this.lblLevelNum.BackColor = System.Drawing.Color.Black;
            this.lblLevelNum.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelNum.ForeColor = System.Drawing.Color.White;
            this.lblLevelNum.Location = new System.Drawing.Point(729, 628);
            this.lblLevelNum.Name = "lblLevelNum";
            this.lblLevelNum.Size = new System.Drawing.Size(49, 33);
            this.lblLevelNum.TabIndex = 11;
            this.lblLevelNum.Text = "00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // pbStatsI
            // 
            this.pbStatsI.Location = new System.Drawing.Point(40, 195);
            this.pbStatsI.Name = "pbStatsI";
            this.pbStatsI.Size = new System.Drawing.Size(80, 20);
            this.pbStatsI.TabIndex = 13;
            this.pbStatsI.TabStop = false;
            // 
            // pbStatsJ
            // 
            this.pbStatsJ.Location = new System.Drawing.Point(51, 244);
            this.pbStatsJ.Name = "pbStatsJ";
            this.pbStatsJ.Size = new System.Drawing.Size(60, 40);
            this.pbStatsJ.TabIndex = 14;
            this.pbStatsJ.TabStop = false;
            // 
            // pbStatsL
            // 
            this.pbStatsL.Location = new System.Drawing.Point(51, 311);
            this.pbStatsL.Name = "pbStatsL";
            this.pbStatsL.Size = new System.Drawing.Size(60, 40);
            this.pbStatsL.TabIndex = 15;
            this.pbStatsL.TabStop = false;
            // 
            // pbStatsO
            // 
            this.pbStatsO.Location = new System.Drawing.Point(60, 376);
            this.pbStatsO.Name = "pbStatsO";
            this.pbStatsO.Size = new System.Drawing.Size(40, 40);
            this.pbStatsO.TabIndex = 16;
            this.pbStatsO.TabStop = false;
            // 
            // pbStatsS
            // 
            this.pbStatsS.Location = new System.Drawing.Point(51, 439);
            this.pbStatsS.Name = "pbStatsS";
            this.pbStatsS.Size = new System.Drawing.Size(60, 40);
            this.pbStatsS.TabIndex = 17;
            this.pbStatsS.TabStop = false;
            // 
            // pbStatsT
            // 
            this.pbStatsT.Location = new System.Drawing.Point(51, 503);
            this.pbStatsT.Name = "pbStatsT";
            this.pbStatsT.Size = new System.Drawing.Size(60, 40);
            this.pbStatsT.TabIndex = 18;
            this.pbStatsT.TabStop = false;
            // 
            // pbStatsZ
            // 
            this.pbStatsZ.Location = new System.Drawing.Point(51, 567);
            this.pbStatsZ.Name = "pbStatsZ";
            this.pbStatsZ.Size = new System.Drawing.Size(60, 40);
            this.pbStatsZ.TabIndex = 19;
            this.pbStatsZ.TabStop = false;
            // 
            // lblStatsI
            // 
            this.lblStatsI.BackColor = System.Drawing.Color.Black;
            this.lblStatsI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsI.ForeColor = System.Drawing.Color.White;
            this.lblStatsI.Location = new System.Drawing.Point(150, 195);
            this.lblStatsI.Name = "lblStatsI";
            this.lblStatsI.Size = new System.Drawing.Size(45, 24);
            this.lblStatsI.TabIndex = 20;
            this.lblStatsI.Text = "x   0";
            // 
            // lblStatsZ
            // 
            this.lblStatsZ.BackColor = System.Drawing.Color.Black;
            this.lblStatsZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsZ.ForeColor = System.Drawing.Color.White;
            this.lblStatsZ.Location = new System.Drawing.Point(150, 574);
            this.lblStatsZ.Name = "lblStatsZ";
            this.lblStatsZ.Size = new System.Drawing.Size(45, 24);
            this.lblStatsZ.TabIndex = 21;
            this.lblStatsZ.Text = "x   0";
            // 
            // lblStatsT
            // 
            this.lblStatsT.BackColor = System.Drawing.Color.Black;
            this.lblStatsT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsT.ForeColor = System.Drawing.Color.White;
            this.lblStatsT.Location = new System.Drawing.Point(150, 510);
            this.lblStatsT.Name = "lblStatsT";
            this.lblStatsT.Size = new System.Drawing.Size(45, 24);
            this.lblStatsT.TabIndex = 22;
            this.lblStatsT.Text = "x   0";
            // 
            // lblStatsS
            // 
            this.lblStatsS.BackColor = System.Drawing.Color.Black;
            this.lblStatsS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsS.ForeColor = System.Drawing.Color.White;
            this.lblStatsS.Location = new System.Drawing.Point(150, 446);
            this.lblStatsS.Name = "lblStatsS";
            this.lblStatsS.Size = new System.Drawing.Size(45, 24);
            this.lblStatsS.TabIndex = 23;
            this.lblStatsS.Text = "x   0";
            // 
            // lblStatsO
            // 
            this.lblStatsO.BackColor = System.Drawing.Color.Black;
            this.lblStatsO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsO.ForeColor = System.Drawing.Color.White;
            this.lblStatsO.Location = new System.Drawing.Point(150, 384);
            this.lblStatsO.Name = "lblStatsO";
            this.lblStatsO.Size = new System.Drawing.Size(45, 24);
            this.lblStatsO.TabIndex = 24;
            this.lblStatsO.Text = "x   0";
            // 
            // lblStatsL
            // 
            this.lblStatsL.BackColor = System.Drawing.Color.Black;
            this.lblStatsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsL.ForeColor = System.Drawing.Color.White;
            this.lblStatsL.Location = new System.Drawing.Point(150, 318);
            this.lblStatsL.Name = "lblStatsL";
            this.lblStatsL.Size = new System.Drawing.Size(45, 24);
            this.lblStatsL.TabIndex = 25;
            this.lblStatsL.Text = "x   0";
            // 
            // lblStatsJ
            // 
            this.lblStatsJ.BackColor = System.Drawing.Color.Black;
            this.lblStatsJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsJ.ForeColor = System.Drawing.Color.White;
            this.lblStatsJ.Location = new System.Drawing.Point(150, 251);
            this.lblStatsJ.Name = "lblStatsJ";
            this.lblStatsJ.Size = new System.Drawing.Size(45, 24);
            this.lblStatsJ.TabIndex = 26;
            this.lblStatsJ.Text = "x   0";
            // 
            // TetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(861, 920);
            this.Controls.Add(this.lblStatsJ);
            this.Controls.Add(this.lblStatsL);
            this.Controls.Add(this.lblStatsO);
            this.Controls.Add(this.lblStatsS);
            this.Controls.Add(this.lblStatsT);
            this.Controls.Add(this.lblStatsZ);
            this.Controls.Add(this.lblStatsI);
            this.Controls.Add(this.pbStatsZ);
            this.Controls.Add(this.pbStatsT);
            this.Controls.Add(this.pbStatsS);
            this.Controls.Add(this.pbStatsO);
            this.Controls.Add(this.pbStatsL);
            this.Controls.Add(this.pbStatsJ);
            this.Controls.Add(this.pbStatsI);
            this.Controls.Add(this.lblLevelNum);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.pbNextShape);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTopScore);
            this.Controls.Add(this.pbGameBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TetrisGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TetrisGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TetrisGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextShape)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatsZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameBoard;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbNextShape;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblLevel;
        public System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblLevelNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbStatsI;
        private System.Windows.Forms.PictureBox pbStatsJ;
        private System.Windows.Forms.PictureBox pbStatsL;
        private System.Windows.Forms.PictureBox pbStatsO;
        private System.Windows.Forms.PictureBox pbStatsS;
        private System.Windows.Forms.PictureBox pbStatsT;
        private System.Windows.Forms.PictureBox pbStatsZ;
        private System.Windows.Forms.Label lblStatsI;
        private System.Windows.Forms.Label lblStatsZ;
        private System.Windows.Forms.Label lblStatsT;
        private System.Windows.Forms.Label lblStatsS;
        private System.Windows.Forms.Label lblStatsO;
        private System.Windows.Forms.Label lblStatsL;
        private System.Windows.Forms.Label lblStatsJ;
    }
}

