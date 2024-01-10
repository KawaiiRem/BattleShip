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

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer dispatcherTimer2 = new System.Windows.Threading.DispatcherTimer();


        private int randTurn = 0;
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
            mineField2.setStateTite(1);


            mineField2.drawMineSquare();

            ulti.addUlti();
            ulti.addSkill();
            mineField.drawMineSquare();
            AI.setShip();


            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
        }

        public void attack()
        {
            if (mineField2.attack())
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
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
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
            dispatcherTimer.Stop();


            getTurn();
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
            //Utilities.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;


            getTurn();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {


        }

        private void getTurn()
        {

            if (randTurn == 1)
            {
                panel3.Visible = true;
                panel3.BringToFront();
                panel4.Visible = false;
                panel2.Visible = false;
                panel1.Visible = true;
                randTurn++;


            }
            else if (randTurn == 0)
            {
                panel4.Visible = true;
                panel4.BringToFront();
                panel3.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                randTurn--;

            }

            /*if (randTurn == 0)
            {
                panel3.Visible = true;
                panel3.BringToFront();
                panel4.Visible = false;
                panel2.Visible = false;
                panel1.Visible = true;
                randTurn++;


            }
            else if (randTurn == 1)
            {
                panel4.Visible = true;
                panel4.BringToFront();
                panel3.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                randTurn--;




            }
            else
            {
                randTurn = new Random().Next(0, 1);
                //if (randTurn == 0)
                //{
                    panel3.Visible = true;
                    panel3.BringToFront();
                    panel4.Visible = false;
                    panel2.Visible = false;
                    panel1.Visible = true;
                    randTurn++;

            //    }
            /*
                else
                {
                    panel4.Visible = true;
                    panel4.BringToFront();
                    panel3.Visible = false;
                    panel1.Visible = false;
                    panel2.Visible = true;
                    randTurn--;
                    dispatcherTimer.Start();


                }
                
            }
            */

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
