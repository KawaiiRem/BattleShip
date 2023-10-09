using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace GameScreen
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        private SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            _soundPlayer = new SoundPlayer("Usagi Flap.wav");
        }

        private void StartGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();

            gameWindow.Show();
            this.Hide();
        }

        private void Setting(object sender, EventArgs e)
        {
            Setting set = new Setting();

            set.Show();
            this.Hide();
        }

        private void PlayMusic(object sender, EventArgs e)
        {
            if (duelStateButton.Checked)
            {
                duelStateButton.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                duelStateButton.Text = "Play";
                _soundPlayer.Stop();
            }
        }
    }
}
