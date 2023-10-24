namespace BenjaminShirk_ST10081854_ProgPart1
{
    partial class Menu
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
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::BenjaminShirk_ST10081854_ProgPart1.Properties.Resources.BackgroundImage;
            this.pnlBackground.Controls.Add(this.btnFindingCallNumbers);
            this.pnlBackground.Controls.Add(this.btnIdentifyingAreas);
            this.pnlBackground.Controls.Add(this.btnClose);
            this.pnlBackground.Controls.Add(this.btnHelp);
            this.pnlBackground.Controls.Add(this.btnStartGame);
            this.pnlBackground.Controls.Add(this.lblMenu);
            this.pnlBackground.Controls.Add(this.lblName);
            this.pnlBackground.Location = new System.Drawing.Point(2, 2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(717, 438);
            this.pnlBackground.TabIndex = 2;
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(35, 195);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(185, 30);
            this.btnFindingCallNumbers.TabIndex = 6;
            this.btnFindingCallNumbers.Text = "Finding Call Numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = true;
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(485, 195);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(185, 30);
            this.btnIdentifyingAreas.TabIndex = 5;
            this.btnIdentifyingAreas.Text = "Identifying Areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(635, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Quit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(635, 46);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 30);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(260, 195);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(185, 30);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Replacing Books";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(305, 150);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(85, 31);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(222, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(249, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "BookShelf Mania";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 441);
            this.Controls.Add(this.pnlBackground);
            this.Name = "Menu";
            this.Text = "Menu";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFindingCallNumbers;
        private System.Windows.Forms.Button btnIdentifyingAreas;
    }
}