namespace BenjaminShirk_ST10081854_ProgPart1
{
    partial class BookShelfGame
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
            this.pnlBookcase = new System.Windows.Forms.Panel();
            this.lstCorrectSortedList = new System.Windows.Forms.ListView();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCallNum = new System.Windows.Forms.Label();
            this.PBBookGameProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnDown = new System.Windows.Forms.Button();
            this.lstBookList = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.PnlBookCaseHolder = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblTotalScoreNumber = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblScoreNumber = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnResetTotalScore = new System.Windows.Forms.Button();
            this.pnlBookcase.SuspendLayout();
            this.PnlBookCaseHolder.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBookcase
            // 
            this.pnlBookcase.BackgroundImage = global::BenjaminShirk_ST10081854_ProgPart1.Properties.Resources.Bookshelf;
            this.pnlBookcase.Controls.Add(this.lstCorrectSortedList);
            this.pnlBookcase.Controls.Add(this.btnNewGame);
            this.pnlBookcase.Controls.Add(this.lblResults);
            this.pnlBookcase.Controls.Add(this.lblCallNum);
            this.pnlBookcase.Controls.Add(this.PBBookGameProgressBar);
            this.pnlBookcase.Controls.Add(this.btnDown);
            this.pnlBookcase.Controls.Add(this.lstBookList);
            this.pnlBookcase.Controls.Add(this.btnUp);
            this.pnlBookcase.Location = new System.Drawing.Point(0, 0);
            this.pnlBookcase.Name = "pnlBookcase";
            this.pnlBookcase.Size = new System.Drawing.Size(499, 300);
            this.pnlBookcase.TabIndex = 0;
            // 
            // lstCorrectSortedList
            // 
            this.lstCorrectSortedList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstCorrectSortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCorrectSortedList.HideSelection = false;
            this.lstCorrectSortedList.Location = new System.Drawing.Point(296, 37);
            this.lstCorrectSortedList.Name = "lstCorrectSortedList";
            this.lstCorrectSortedList.Size = new System.Drawing.Size(175, 245);
            this.lstCorrectSortedList.TabIndex = 26;
            this.lstCorrectSortedList.UseCompatibleStateImageBehavior = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(204, 201);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(86, 47);
            this.btnNewGame.TabIndex = 26;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Transparent;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.White;
            this.lblResults.Location = new System.Drawing.Point(358, 18);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(113, 16);
            this.lblResults.TabIndex = 28;
            this.lblResults.Text = "Correct Results";
            // 
            // lblCallNum
            // 
            this.lblCallNum.AutoSize = true;
            this.lblCallNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCallNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallNum.ForeColor = System.Drawing.Color.White;
            this.lblCallNum.Location = new System.Drawing.Point(20, 18);
            this.lblCallNum.Name = "lblCallNum";
            this.lblCallNum.Size = new System.Drawing.Size(100, 16);
            this.lblCallNum.TabIndex = 27;
            this.lblCallNum.Text = "Call Numbers";
            // 
            // PBBookGameProgressBar
            // 
            this.PBBookGameProgressBar.Location = new System.Drawing.Point(146, 5);
            this.PBBookGameProgressBar.Name = "PBBookGameProgressBar";
            this.PBBookGameProgressBar.Size = new System.Drawing.Size(200, 29);
            this.PBBookGameProgressBar.TabIndex = 26;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(204, 152);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(86, 43);
            this.btnDown.TabIndex = 25;
            this.btnDown.Text = "Book Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lstBookList
            // 
            this.lstBookList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBookList.FormattingEnabled = true;
            this.lstBookList.ItemHeight = 16;
            this.lstBookList.Location = new System.Drawing.Point(23, 38);
            this.lstBookList.Name = "lstBookList";
            this.lstBookList.Size = new System.Drawing.Size(175, 244);
            this.lstBookList.TabIndex = 0;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(204, 105);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(86, 41);
            this.btnUp.TabIndex = 24;
            this.btnUp.Text = "Book Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // PnlBookCaseHolder
            // 
            this.PnlBookCaseHolder.Controls.Add(this.pnlBookcase);
            this.PnlBookCaseHolder.Location = new System.Drawing.Point(107, 80);
            this.PnlBookCaseHolder.Name = "PnlBookCaseHolder";
            this.PnlBookCaseHolder.Size = new System.Drawing.Size(496, 299);
            this.PnlBookCaseHolder.TabIndex = 18;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::BenjaminShirk_ST10081854_ProgPart1.Properties.Resources.BackgroundImage;
            this.pnlBackground.Controls.Add(this.btnResetTotalScore);
            this.pnlBackground.Controls.Add(this.lblTotalScoreNumber);
            this.pnlBackground.Controls.Add(this.lblTotalScore);
            this.pnlBackground.Controls.Add(this.btnBack);
            this.pnlBackground.Controls.Add(this.lblScoreNumber);
            this.pnlBackground.Controls.Add(this.lblScore);
            this.pnlBackground.Controls.Add(this.lblName);
            this.pnlBackground.Controls.Add(this.btnEnter);
            this.pnlBackground.Controls.Add(this.PnlBookCaseHolder);
            this.pnlBackground.Location = new System.Drawing.Point(0, -1);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(716, 502);
            this.pnlBackground.TabIndex = 19;
            // 
            // lblTotalScoreNumber
            // 
            this.lblTotalScoreNumber.AutoSize = true;
            this.lblTotalScoreNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalScoreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScoreNumber.ForeColor = System.Drawing.Color.White;
            this.lblTotalScoreNumber.Location = new System.Drawing.Point(612, 53);
            this.lblTotalScoreNumber.Name = "lblTotalScoreNumber";
            this.lblTotalScoreNumber.Size = new System.Drawing.Size(19, 20);
            this.lblTotalScoreNumber.TabIndex = 25;
            this.lblTotalScoreNumber.Text = "0";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.White;
            this.lblTotalScore.Location = new System.Drawing.Point(495, 53);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(111, 20);
            this.lblTotalScore.TabIndex = 24;
            this.lblTotalScore.Text = "Total Score :";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(107, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblScoreNumber
            // 
            this.lblScoreNumber.AutoSize = true;
            this.lblScoreNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNumber.ForeColor = System.Drawing.Color.White;
            this.lblScoreNumber.Location = new System.Drawing.Point(612, 30);
            this.lblScoreNumber.Name = "lblScoreNumber";
            this.lblScoreNumber.Size = new System.Drawing.Size(19, 20);
            this.lblScoreNumber.TabIndex = 22;
            this.lblScoreNumber.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(540, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 20);
            this.lblScore.TabIndex = 21;
            this.lblScore.Text = "Score :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(231, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(242, 24);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Welcome To Book Order";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(528, 386);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 30);
            this.btnEnter.TabIndex = 19;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnResetTotalScore
            // 
            this.btnResetTotalScore.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTotalScore.Location = new System.Drawing.Point(616, 80);
            this.btnResetTotalScore.Name = "btnResetTotalScore";
            this.btnResetTotalScore.Size = new System.Drawing.Size(75, 30);
            this.btnResetTotalScore.TabIndex = 26;
            this.btnResetTotalScore.Text = "Reset";
            this.btnResetTotalScore.UseVisualStyleBackColor = false;
            this.btnResetTotalScore.Click += new System.EventHandler(this.btnResetTotalScore_Click);
            // 
            // BookShelfGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 498);
            this.Controls.Add(this.pnlBackground);
            this.Name = "BookShelfGame";
            this.Text = "BookShelfGame";
            this.pnlBookcase.ResumeLayout(false);
            this.pnlBookcase.PerformLayout();
            this.PnlBookCaseHolder.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBookcase;
        private System.Windows.Forms.Panel PnlBookCaseHolder;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstBookList;
        private System.Windows.Forms.ProgressBar PBBookGameProgressBar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblCallNum;
        private System.Windows.Forms.Label lblTotalScoreNumber;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ListView lstCorrectSortedList;
        private System.Windows.Forms.Button btnResetTotalScore;
    }
}