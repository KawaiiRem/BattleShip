using MineSweaper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region properties
        MineFieldManager mineField;
        MineFieldManager mineField2;


        #endregion
        public Form1()
        {

            InitializeComponent();
            mineField = new MineFieldManager(panel1);
            mineField2 = new MineFieldManager(panel2);

            MachineAction AI = new MachineAction(mineField);
            Ulti ulti = new Ulti(Utilities, mineField);

           


            mineField2.drawMineSquare();

            ulti.addUlti();
            mineField.drawMineSquare();
            AI.setShip();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mineField.setSignal(Constant.LshapeID);
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Move);
        }

        private void pictureBox1_MouseClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            mineField.setSignal(Constant.LshapeID);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mineField.setSignal(Constant.LongPieceID);
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Move);
        }

        private void pictureBox2_MouseClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            mineField.setSignal(Constant.LongPieceID);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            mineField.setSignal(Constant.BeegBoiID);
            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Move);
        }

        private void pictureBox3_MouseClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            mineField.setSignal(Constant.BeegBoiID);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            mineField.setSignal(Constant.ShortPieceID);
            pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.Move);
        }

        private void pictureBox4_MouseClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            mineField.setSignal(Constant.ShortPieceID);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnDone.Visible = false;
            Utilities.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;


            mineField2 = new MineFieldManager(panel2);
            mineField2.drawMineSquare();
            mineField2.updateTiteState(1);

            getTurn();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = true;

            }                         
            else
            {
                panel2.Visible = false;
                panel1.Visible = true;

            }

        }

        private void getTurn()
        {
            int randTurn = new Random().Next(0, 1);
            if (randTurn < 1)
            {
                panel3.Visible = true;
                panel3.BringToFront();
                panel2.Visible=false;
                panel1.Visible=true;
            }
            else
            {   //me
                panel4.Visible = true;
                panel4.BringToFront();
                panel1.Visible=false;
                panel2.Visible=true;
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.Visible = false;
        }
        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Visible = false;
        }
    }
}
