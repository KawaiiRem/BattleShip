namespace GameScreen
{
    partial class Volume_Adjust
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volume_Adjust));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.volume_Controll1 = new Volume_Controll();
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume: 40%";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playMusic
            // 
            this.playMusic.Enabled = true;
            this.playMusic.Location = new System.Drawing.Point(12, 57);
            this.playMusic.Name = "playMusic";
            this.playMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playMusic.OcxState")));
            this.playMusic.Size = new System.Drawing.Size(668, 195);
            this.playMusic.TabIndex = 2;
            // 
            // volume_Controll1
            // 
            this.volume_Controll1.BackColor = System.Drawing.Color.Black;
            this.volume_Controll1.Bar_color = System.Drawing.Color.Aqua;
            this.volume_Controll1.Location = new System.Drawing.Point(74, 318);
            this.volume_Controll1.Max = 100;
            this.volume_Controll1.Min = 0;
            this.volume_Controll1.Name = "volume_Controll1";
            this.volume_Controll1.Size = new System.Drawing.Size(520, 30);
            this.volume_Controll1.TabIndex = 0;
            this.volume_Controll1.Value = 40;
            this.volume_Controll1.Load += new System.EventHandler(this.volume_Controll1_Load);
            this.volume_Controll1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volume_Controll1_MouseMove);
            // 
            // Volume_Adjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 360);
            this.Controls.Add(this.playMusic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volume_Controll1);
            this.Name = "Volume_Adjust";
            this.Text = "Volume_Adjust";
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Volume_Controll volume_Controll1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer playMusic;
    }
}