using MineSweaper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public class Tile
    {
        private int posRow;
        private int posColume;
        private Button button;
        private Boolean shipPart = false;
        private MineFieldManager fieldManager;
        private int type = 0;
        private List<Vertex> visitedVertex;

        public Tile(Button button, int posRow, int posColume, MineFieldManager fieldManager)
        {
            visitedVertex = new List<Vertex>();
            this.button = button;
            this.posRow = posRow;
            this.posColume = posColume;
            this.fieldManager = fieldManager;
        }
        
        public void formShipAction()
        {
            this.button.DragEnter += new System.Windows.Forms.DragEventHandler(btnEventEnterShip);
            this.button.AllowDrop = true;
        }

        public void removeShipAction()
        {
            this.button.DragEnter -= new System.Windows.Forms.DragEventHandler(btnEventEnterShip);
            this.button.AllowDrop = false;
        }
    
        public void formSkillAction()
        {
            this.button.DragEnter += new System.Windows.Forms.DragEventHandler(btnEventEnterSkill);
            this.button.DragDrop += new System.Windows.Forms.DragEventHandler(btnEventReleaseShip);
            this.button.Click += new System.EventHandler(attackPlayer);
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

        public void reDraw()
        {
            if (shipPart == true)
            {
                button.BackColor = Color.Black;
            }
            else if (shipPart == false)
            {
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

        public void drawPart(int posRow, int posColume, int type)
        {
            fieldManager.getTile(posRow, posColume).setType(type);
            fieldManager.drawPart(posRow, posColume);
        }
        
        public void reset(int posRow, int posColume)
        {
            fieldManager.reset(posRow, posColume);
            fieldManager.getTile(posRow, posColume).setType(0);
        }

        public int getPosRow()
        {
            return posRow;
        }

        public int getPosColume()
        {
            return posColume;
        }
        public Button getButton()
        {
            return button;
        }
        public void btnEventEnterSkill(Object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            fieldManager.getSkill().setTile(this);
        }

        public void btnEventEnterShip(Object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            fieldManager.getShip().setTile(this);
        }

        public void btnEventReleaseShip(Object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            fieldManager.getSkill().attack();
            fieldManager.togglePanel();
        }

        public void attackPlayer(Object sender, EventArgs e)
        {
            button = sender as Button;
            //fieldManager.getGraph().BFS(fieldManager.getGraph().getVertex(button), visitedVertex);
            attack();
            fieldManager.getProgress().anounce();
            fieldManager.togglePanel();
        }

        public void attack()
        {
            if (type != 0)
            {
                if (fieldManager.getAI().getActive())
                    fieldManager.getGraph().BFS(fieldManager.getGraph().getVertex(this.button), fieldManager.getAI().getTileToAttack());
                button.BackColor = Color.Red;
                if (type == Constant.ShortPieceID)
                    fieldManager.getProgress().ShortHPReduce();
                if (type == Constant.LshapeID)
                    fieldManager.getProgress().LshapeHPReduce();
                if (type == Constant.LongPieceID)
                    fieldManager.getProgress().LongHPReduce();
                if (type == Constant.BeegBoiID)
                    fieldManager.getProgress().BeegBoiHPReduce();
            }
            else
                button.BackColor = Color.Gray;
            if (fieldManager.getAI().getActive())
            { 
                fieldManager.getAI().getTileToAttack().Remove(fieldManager.getGraph().getVertex(button));
                fieldManager.getGraph().removeVertex(fieldManager.getGraph().getVertex(button));
            }
            button.Enabled = false;
        }
    }
}
