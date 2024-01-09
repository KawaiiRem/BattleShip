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
        public Ulti(Panel ulti, MineFieldManager fieldManager)
        {
            this.panel = ulti;
            this.fieldManager = fieldManager;
        }

        public void addUlti()
        {
            Button rotate = new Button()
            {
                Text = "Rotate",
                Width = 100,
                Height = 50,
                
                BackColor = Color.Gray,
            };
            rotate.Click += new System.EventHandler(Rotate_Click);
            panel.Controls.Add(rotate);
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
    }
}
