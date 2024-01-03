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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region properties
        MineFieldManager mineField;
        #endregion
        public Form1()
        {
       
            InitializeComponent();
            mineField = new MineFieldManager(panel1);
            Ulti ulti = new Ulti(Utilities,mineField);
            ulti.addUlti();
            mineField.drawMineSquare();
            
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
