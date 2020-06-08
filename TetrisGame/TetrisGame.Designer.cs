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
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextShape)).BeginInit();
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
            // TetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(861, 920);
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
            this.Name = "TetrisGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TetrisGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextShape)).EndInit();
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
    }
}

