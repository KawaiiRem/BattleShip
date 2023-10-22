using MineSweaper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Tile
    {
        private int coordX;
        private int coordY;
        private Button button;
        private Boolean shipPart = false;
        private MineFieldManager fieldManager;
        private int type = 0;

        public Tile(Button button, int coordX, int coordY, MineFieldManager fieldManager)
        {
            this.button = button;
            this.coordX = coordX;
            this.coordY = coordY;
            this.fieldManager = fieldManager;
            this.button.DragEnter += new System.Windows.Forms.DragEventHandler(btnEventEnter);
            this.button.AllowDrop = true;
        }

        public void isShip(Boolean input)
        {
            if (input == true)
            {
                shipPart = true;
                button.BackColor = Color.Black;
            }
            else if (input == false)
            {
                shipPart = false;
                button.BackColor = Color.Transparent;
            }
        }
        public int getType()
        {
            return type;
        }

        public void setType(int type)
        {
            this.type = type;
        }

        public bool getIsShip()
        {
            return shipPart;
        }

        public void drawPart(int x, int y, int type)
        {
            fieldManager.getTile(x, y).setType(type);
            fieldManager.drawPart(x, y);
        }
        
        public void reset(int x, int y)
        {
            fieldManager.reset(x, y);
            fieldManager.getTile(x, y).setType(0);
        }

        public int getCoordX()
        {
            return coordX;
        }

        public int getCoordY()
        {
            return coordY;
        }
        public Button getButton()
        {
            return button;
        }
        public void btnEventEnter(Object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            fieldManager.getShip().setTile(this);
        }
    }
}
