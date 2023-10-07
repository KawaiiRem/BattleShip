namespace BattleShip
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.btnPreviousPlay = new System.Windows.Forms.Button();
            this.labelCampain = new System.Windows.Forms.Label();
            this.labelPVP = new System.Windows.Forms.Label();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnPreviousSetting = new System.Windows.Forms.Button();
            this.labelHiddenHW = new System.Windows.Forms.Label();
            this.labelWinSize = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelSetting = new System.Windows.Forms.Label();
            this.labelPlay = new System.Windows.Forms.Label();
            this.labelMainName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelSetting);
            this.panel1.Controls.Add(this.panelPlay);
            this.panel1.Controls.Add(this.labelCredit);
            this.panel1.Controls.Add(this.labelSetting);
            this.panel1.Controls.Add(this.labelPlay);
            this.panel1.Controls.Add(this.labelMainName);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 580);
            this.panel1.TabIndex = 1;
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlay.Controls.Add(this.btnPreviousPlay);
            this.panelPlay.Controls.Add(this.labelCampain);
            this.panelPlay.Controls.Add(this.labelPVP);
            this.panelPlay.Location = new System.Drawing.Point(0, 0);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(1200, 580);
            this.panelPlay.TabIndex = 2;
            // 
            // btnPreviousPlay
            // 
            this.btnPreviousPlay.BackColor = System.Drawing.Color.SlateGray;
            this.btnPreviousPlay.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnPreviousPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPreviousPlay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreviousPlay.Location = new System.Drawing.Point(70, 447);
            this.btnPreviousPlay.Name = "btnPreviousPlay";
            this.btnPreviousPlay.Size = new System.Drawing.Size(133, 44);
            this.btnPreviousPlay.TabIndex = 2;
            this.btnPreviousPlay.Text = "Previous";
            this.btnPreviousPlay.UseVisualStyleBackColor = false;
            this.btnPreviousPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // labelCampain
            // 
            this.labelCampain.AutoSize = true;
            this.labelCampain.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelCampain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCampain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampain.Location = new System.Drawing.Point(442, 257);
            this.labelCampain.Name = "labelCampain";
            this.labelCampain.Padding = new System.Windows.Forms.Padding(61, 24, 61, 24);
            this.labelCampain.Size = new System.Drawing.Size(302, 93);
            this.labelCampain.TabIndex = 1;
            this.labelCampain.Text = "Campain";
            // 
            // labelPVP
            // 
            this.labelPVP.AutoSize = true;
            this.labelPVP.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelPVP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPVP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPVP.Location = new System.Drawing.Point(442, 120);
            this.labelPVP.Name = "labelPVP";
            this.labelPVP.Padding = new System.Windows.Forms.Padding(102, 24, 102, 24);
            this.labelPVP.Size = new System.Drawing.Size(300, 93);
            this.labelPVP.TabIndex = 0;
            this.labelPVP.Text = "PVP";
            // 
            // panelSetting
            // 
            this.panelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSetting.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSetting.Controls.Add(this.btnPreviousSetting);
            this.panelSetting.Controls.Add(this.labelHiddenHW);
            this.panelSetting.Controls.Add(this.labelWinSize);
            this.panelSetting.Controls.Add(this.labelSound);
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(1200, 580);
            this.panelSetting.TabIndex = 3;
            // 
            // btnPreviousSetting
            // 
            this.btnPreviousSetting.BackColor = System.Drawing.Color.SlateGray;
            this.btnPreviousSetting.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnPreviousSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPreviousSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreviousSetting.Location = new System.Drawing.Point(60, 466);
            this.btnPreviousSetting.Name = "btnPreviousSetting";
            this.btnPreviousSetting.Size = new System.Drawing.Size(133, 44);
            this.btnPreviousSetting.TabIndex = 3;
            this.btnPreviousSetting.Text = "Previous";
            this.btnPreviousSetting.UseVisualStyleBackColor = false;
            this.btnPreviousSetting.Click += new System.EventHandler(this.btnPreviousSetting_Click);
            // 
            // labelHiddenHW
            // 
            this.labelHiddenHW.AutoSize = true;
            this.labelHiddenHW.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelHiddenHW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHiddenHW.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHiddenHW.Location = new System.Drawing.Point(400, 366);
            this.labelHiddenHW.Name = "labelHiddenHW";
            this.labelHiddenHW.Padding = new System.Windows.Forms.Padding(24);
            this.labelHiddenHW.Size = new System.Drawing.Size(400, 93);
            this.labelHiddenHW.TabIndex = 2;
            this.labelHiddenHW.Text = "Hidden Homework";
            // 
            // labelWinSize
            // 
            this.labelWinSize.AutoSize = true;
            this.labelWinSize.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelWinSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWinSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinSize.Location = new System.Drawing.Point(400, 243);
            this.labelWinSize.Name = "labelWinSize";
            this.labelWinSize.Padding = new System.Windows.Forms.Padding(76, 24, 76, 24);
            this.labelWinSize.Size = new System.Drawing.Size(400, 93);
            this.labelWinSize.TabIndex = 1;
            this.labelWinSize.Text = "Window Size";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSound.Location = new System.Drawing.Point(400, 120);
            this.labelSound.Name = "labelSound";
            this.labelSound.Padding = new System.Windows.Forms.Padding(133, 24, 133, 24);
            this.labelSound.Size = new System.Drawing.Size(401, 93);
            this.labelSound.TabIndex = 0;
            this.labelSound.Text = "Sound";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCredit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(441, 398);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Padding = new System.Windows.Forms.Padding(50, 24, 136, 24);
            this.labelCredit.Size = new System.Drawing.Size(318, 93);
            this.labelCredit.TabIndex = 3;
            this.labelCredit.Text = "Credit";
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSetting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetting.Location = new System.Drawing.Point(441, 275);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Padding = new System.Windows.Forms.Padding(50, 24, 119, 24);
            this.labelSetting.Size = new System.Drawing.Size(318, 93);
            this.labelSetting.TabIndex = 2;
            this.labelSetting.Text = "Setting";
            this.labelSetting.Click += new System.EventHandler(this.setting_Click);
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlay.Location = new System.Drawing.Point(441, 152);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Padding = new System.Windows.Forms.Padding(50, 24, 170, 24);
            this.labelPlay.Size = new System.Drawing.Size(318, 93);
            this.labelPlay.TabIndex = 1;
            this.labelPlay.Text = "Play";
            this.labelPlay.Click += new System.EventHandler(this.play_Click);
            // 
            // labelMainName
            // 
            this.labelMainName.AutoSize = true;
            this.labelMainName.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainName.Location = new System.Drawing.Point(180, 44);
            this.labelMainName.Name = "labelMainName";
            this.labelMainName.Size = new System.Drawing.Size(841, 66);
            this.labelMainName.TabIndex = 0;
            this.labelMainName.Text = "BATTLESHIP [MAIN SCREEN]";
            this.labelMainName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 628);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMainName;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Label labelCampain;
        private System.Windows.Forms.Label labelPVP;
        private System.Windows.Forms.Button btnPreviousPlay;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Label labelHiddenHW;
        private System.Windows.Forms.Label labelWinSize;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Button btnPreviousSetting;
    }
}

