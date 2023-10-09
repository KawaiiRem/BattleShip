using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
    public partial class Volume_Adjust : Form
    {
        
        public Volume_Adjust()
        {
            InitializeComponent();
            
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Volume :" + volume_Controll1.Value.ToString() + "%";
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void volume_Controll1_MouseMove(object sender, MouseEventArgs e)
        {
            playMusic.settings.volume = volume_Controll1.Value;
            label1.Text = "Volume :" + volume_Controll1.Value.ToString() + "%";
            
        }

        private void volume_Controll1_Load(object sender, EventArgs e)
        {
            playMusic.URL = "C:\\Users\\admin\\source\\repos\\GameScreen\\GameScreen\\bin\\Debug\\Usagi_Flap.mp3";
            playMusic.Ctlcontrols.play();
        }
    }
}
