using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
    public partial class GameScreen : Form
    {
        public static GameScreen instance;
        public GameScreen()
        {
            InitializeComponent();
            instance = this;
        }

        private void Campain(object sender, EventArgs e)
        {

        }

        private void BackMenu(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            instance.Hide();
        }
    }
}
