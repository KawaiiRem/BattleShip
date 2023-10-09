using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class Form1 : Form
    {

        List<Panel> listPanel = new List<Panel>();
        int index=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelPlay.Hide();
            panelSetting.Hide();
            panel1.BringToFront();
        }

        private void play_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = true;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = true;
        }

        private void btnPreviousSetting_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = false;
            panelSetting.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = false;
            panelSetting.Visible = false;
        }
    }
}
