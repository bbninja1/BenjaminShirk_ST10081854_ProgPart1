namespace BenjaminShirk_ST10081854_ProgPart1
{
    partial class IdentifyingAreas
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBookcase = new System.Windows.Forms.Panel();
            this.PBBookGameProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblTotalScoreNumber = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblScoreNumber = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.questionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lstListBox4 = new System.Windows.Forms.ListBox();
            this.lstListBox3 = new System.Windows.Forms.ListBox();
            this.lstListBox2 = new System.Windows.Forms.ListBox();
            this.lblQuestion4 = new System.Windows.Forms.Label();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.lstListBox1 = new System.Windows.Forms.ListBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.answerListBox = new System.Windows.Forms.ListBox();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.pnlBookcase.SuspendLayout();
            this.questionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::BenjaminShirk_ST10081854_ProgPart1.Properties.Resources.BackgroundImage;
            this.pnlBackground.Controls.Add(this.btnHelp);
            this.pnlBackground.Controls.Add(this.btnQuestion);
            this.pnlBackground.Controls.Add(this.pnlBookcase);
            this.pnlBackground.Controls.Add(this.btnBack);
            this.pnlBackground.Controls.Add(this.lblName);
            this.pnlBackground.Location = new System.Drawing.Point(-1, -1);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(802, 452);
            this.pnlBackground.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(269, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(290, 24);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Welcome To Identifying Areas";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(36, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlBookcase
            // 
            this.pnlBookcase.BackgroundImage = global::BenjaminShirk_ST10081854_ProgPart1.Properties.Resources.Bookshelf;
            this.pnlBookcase.Controls.Add(this.answerListBox);
            this.pnlBookcase.Controls.Add(this.lblTotalScoreNumber);
            this.pnlBookcase.Controls.Add(this.lblAnswers);
            this.pnlBookcase.Controls.Add(this.lblTotalScore);
            this.pnlBookcase.Controls.Add(this.lblQuestion);
            this.pnlBookcase.Controls.Add(this.lblScoreNumber);
            this.pnlBookcase.Controls.Add(this.questionsPanel);
            this.pnlBookcase.Controls.Add(this.lblScore);
            this.pnlBookcase.Controls.Add(this.PBBookGameProgressBar);
            this.pnlBookcase.Location = new System.Drawing.Point(68, 76);
            this.pnlBookcase.Name = "pnlBookcase";
            this.pnlBookcase.Size = new System.Drawing.Size(676, 300);
            this.pnlBookcase.TabIndex = 25;
            // 
            // PBBookGameProgressBar
            // 
            this.PBBookGameProgressBar.Location = new System.Drawing.Point(250, 3);
            this.PBBookGameProgressBar.Name = "PBBookGameProgressBar";
            this.PBBookGameProgressBar.Size = new System.Drawing.Size(200, 29);
            this.PBBookGameProgressBar.TabIndex = 26;
            // 
            // lblTotalScoreNumber
            // 
            this.lblTotalScoreNumber.AutoSize = true;
            this.lblTotalScoreNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalScoreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScoreNumber.ForeColor = System.Drawing.Color.Black;
            this.lblTotalScoreNumber.Location = new System.Drawing.Point(647, 35);
            this.lblTotalScoreNumber.Name = "lblTotalScoreNumber";
            this.lblTotalScoreNumber.Size = new System.Drawing.Size(19, 20);
            this.lblTotalScoreNumber.TabIndex = 29;
            this.lblTotalScoreNumber.Text = "0";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.Black;
            this.lblTotalScore.Location = new System.Drawing.Point(530, 35);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(111, 20);
            this.lblTotalScore.TabIndex = 28;
            this.lblTotalScore.Text = "Total Score :";
            // 
            // lblScoreNumber
            // 
            this.lblScoreNumber.AutoSize = true;
            this.lblScoreNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNumber.ForeColor = System.Drawing.Color.Black;
            this.lblScoreNumber.Location = new System.Drawing.Point(647, 12);
            this.lblScoreNumber.Name = "lblScoreNumber";
            this.lblScoreNumber.Size = new System.Drawing.Size(19, 20);
            this.lblScoreNumber.TabIndex = 27;
            this.lblScoreNumber.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(575, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 20);
            this.lblScore.TabIndex = 26;
            this.lblScore.Text = "Score :";
            // 
            // questionsPanel
            // 
            this.questionsPanel.AllowDrop = true;
            this.questionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.questionsPanel.BackColor = System.Drawing.Color.White;
            this.questionsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.questionsPanel.ColumnCount = 3;
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.questionsPanel.Controls.Add(this.lstListBox4, 2, 3);
            this.questionsPanel.Controls.Add(this.lstListBox3, 2, 2);
            this.questionsPanel.Controls.Add(this.lstListBox2, 2, 1);
            this.questionsPanel.Controls.Add(this.lblQuestion4, 1, 3);
            this.questionsPanel.Controls.Add(this.lblQuestion3, 1, 2);
            this.questionsPanel.Controls.Add(this.lblQuestion2, 1, 1);
            this.questionsPanel.Controls.Add(this.lblQuestion1, 1, 0);
            this.questionsPanel.Controls.Add(this.lstListBox1, 2, 0);
            this.questionsPanel.Location = new System.Drawing.Point(17, 73);
            this.questionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.RowCount = 4;
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.Size = new System.Drawing.Size(330, 194);
            this.questionsPanel.TabIndex = 27;
            // 
            // lstListBox4
            // 
            this.lstListBox4.AllowDrop = true;
            this.lstListBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstListBox4.BackColor = System.Drawing.Color.White;
            this.lstListBox4.Font = new System.Drawing.Font("Constantia", 9F);
            this.lstListBox4.FormattingEnabled = true;
            this.lstListBox4.ItemHeight = 14;
            this.lstListBox4.Location = new System.Drawing.Point(184, 160);
            this.lstListBox4.Margin = new System.Windows.Forms.Padding(2);
            this.lstListBox4.Name = "lstListBox4";
            this.lstListBox4.Size = new System.Drawing.Size(139, 18);
            this.lstListBox4.TabIndex = 9;
            // 
            // lstListBox3
            // 
            this.lstListBox3.AllowDrop = true;
            this.lstListBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstListBox3.BackColor = System.Drawing.Color.White;
            this.lstListBox3.Font = new System.Drawing.Font("Constantia", 9F);
            this.lstListBox3.FormattingEnabled = true;
            this.lstListBox3.ItemHeight = 14;
            this.lstListBox3.Location = new System.Drawing.Point(185, 111);
            this.lstListBox3.Margin = new System.Windows.Forms.Padding(2);
            this.lstListBox3.Name = "lstListBox3";
            this.lstListBox3.Size = new System.Drawing.Size(138, 18);
            this.lstListBox3.TabIndex = 8;
            // 
            // lstListBox2
            // 
            this.lstListBox2.AllowDrop = true;
            this.lstListBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstListBox2.BackColor = System.Drawing.Color.White;
            this.lstListBox2.Font = new System.Drawing.Font("Constantia", 9F);
            this.lstListBox2.FormattingEnabled = true;
            this.lstListBox2.ItemHeight = 14;
            this.lstListBox2.Location = new System.Drawing.Point(185, 63);
            this.lstListBox2.Margin = new System.Windows.Forms.Padding(2);
            this.lstListBox2.Name = "lstListBox2";
            this.lstListBox2.Size = new System.Drawing.Size(138, 18);
            this.lstListBox2.TabIndex = 7;
            // 
            // lblQuestion4
            // 
            this.lblQuestion4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuestion4.AutoSize = true;
            this.lblQuestion4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestion4.Location = new System.Drawing.Point(23, 160);
            this.lblQuestion4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion4.Name = "lblQuestion4";
            this.lblQuestion4.Size = new System.Drawing.Size(43, 17);
            this.lblQuestion4.TabIndex = 5;
            this.lblQuestion4.Text = "Item 4";
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestion3.Location = new System.Drawing.Point(23, 112);
            this.lblQuestion3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(43, 17);
            this.lblQuestion3.TabIndex = 4;
            this.lblQuestion3.Text = "Item 3";
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestion2.Location = new System.Drawing.Point(23, 64);
            this.lblQuestion2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(43, 17);
            this.lblQuestion2.TabIndex = 3;
            this.lblQuestion2.Text = "Item 2";
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.Location = new System.Drawing.Point(23, 16);
            this.lblQuestion1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(43, 17);
            this.lblQuestion1.TabIndex = 2;
            this.lblQuestion1.Text = "Item 1";
            // 
            // lstListBox1
            // 
            this.lstListBox1.AllowDrop = true;
            this.lstListBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstListBox1.BackColor = System.Drawing.Color.White;
            this.lstListBox1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListBox1.FormattingEnabled = true;
            this.lstListBox1.ItemHeight = 14;
            this.lstListBox1.Location = new System.Drawing.Point(185, 15);
            this.lstListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.lstListBox1.Name = "lstListBox1";
            this.lstListBox1.Size = new System.Drawing.Size(138, 18);
            this.lstListBox1.TabIndex = 6;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(39, 40);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(101, 20);
            this.lblQuestion.TabIndex = 28;
            this.lblQuestion.Text = "Question 1:";
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers.ForeColor = System.Drawing.Color.Black;
            this.lblAnswers.Location = new System.Drawing.Point(276, 40);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(158, 20);
            this.lblAnswers.TabIndex = 29;
            this.lblAnswers.Text = "Match The Column";
            // 
            // answerListBox
            // 
            this.answerListBox.AllowDrop = true;
            this.answerListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerListBox.BackColor = System.Drawing.Color.White;
            this.answerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerListBox.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerListBox.FormattingEnabled = true;
            this.answerListBox.ItemHeight = 16;
            this.answerListBox.Location = new System.Drawing.Point(351, 73);
            this.answerListBox.Margin = new System.Windows.Forms.Padding(2);
            this.answerListBox.Name = "answerListBox";
            this.answerListBox.Size = new System.Drawing.Size(310, 194);
            this.answerListBox.TabIndex = 30;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.Location = new System.Drawing.Point(613, 391);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(131, 30);
            this.btnQuestion.TabIndex = 30;
            this.btnQuestion.Text = "Next Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(714, 13);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 30);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // IdentifyingAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBackground);
            this.Name = "IdentifyingAreas";
            this.Text = "IdentifyingAreas";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlBookcase.ResumeLayout(false);
            this.pnlBookcase.PerformLayout();
            this.questionsPanel.ResumeLayout(false);
            this.questionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBookcase;
        private System.Windows.Forms.ProgressBar PBBookGameProgressBar;
        private System.Windows.Forms.Label lblTotalScoreNumber;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblScoreNumber;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TableLayoutPanel questionsPanel;
        private System.Windows.Forms.ListBox lstListBox4;
        private System.Windows.Forms.ListBox lstListBox3;
        private System.Windows.Forms.ListBox lstListBox2;
        private System.Windows.Forms.Label lblQuestion4;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.ListBox lstListBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.ListBox answerListBox;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnHelp;
    }
}