using MineSweaper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public class Ulti
    {
        private Panel panel;
        private MineFieldManager fieldManager;
        private Button rotate;
        private Button Godsenger;
        private Button ChenS2;
        public Ulti(Panel ulti, MineFieldManager fieldManager)
        {
            panel = ulti;
            this.fieldManager = fieldManager;
        }

        public void addUlti()
        {
            rotate = new Button()
            {
                Text = "Rotate",
                Width = 100,
                Height = 50,
                
                BackColor = Color.Gray,
            };
            rotate.Click += new System.EventHandler(Rotate_Click);
            panel.Controls.Add(rotate);
        }

        public void addSkill()
        {
            ChenS2 = new Button()
            {
                Text = "ChenS2",
                Width = 100,
                Height = 50,
                Location = new System.Drawing.Point(0,50),
            BackColor = Color.Gray,
            };
            ChenS2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SquareAttack_Click);
            panel.Controls.Add(ChenS2);

            Godsenger = new Button()
            {
                Text = "Godsenger",
                Width = 100,
                Height = 50,
                Location = new System.Drawing.Point(0, 100),
                BackColor = Color.Gray,
            };
            Godsenger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StarAttack_Click);
            panel.Controls.Add(Godsenger);
        }

        public void Rotate_Click(Object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (fieldManager.getSignal() == Constant.LshapeID)
                fieldManager.getLshape().shiftState();
            if (fieldManager.getSignal() == Constant.LongPieceID)
                fieldManager.getLpiece().shiftState();
            if (fieldManager.getSignal() == Constant.BeegBoiID)
                fieldManager.getBeegBoi().shiftState();
            if (fieldManager.getSignal() == Constant.ShortPieceID)
                fieldManager.getShortPiece().shiftState();
        }

        public void SquareAttack_Click(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            fieldManager.setSignal(Constant.squareAtkID);
            ChenS2.DoDragDrop(button, DragDropEffects.Move);
        }

        public void StarAttack_Click(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            fieldManager.setSignal(Constant.starAtkID);
            Godsenger.DoDragDrop(button, DragDropEffects.Move);
        }
    }
}
