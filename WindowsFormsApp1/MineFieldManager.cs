using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.AxHost;

namespace MineSweaper
{
    public class MineFieldManager
    {
        #region properties
        private Panel mineField;
        private int posRow;
        private int posColume;
        private Tile[,] tile;
        private Lshape lshape;
        private LongPiece lpiece;
        private BeegBoi beegboi;
        private ShortPiece spiece;
        private int signalReceive = 0;
        private Graph graph;
        private SquareAttack squareAttack;
        private StarAttack starAttack;
        #endregion

        #region initiate 
        public MineFieldManager(Panel mineField)
        {
            tile = new Tile[Constant.MapRow, Constant.MapColume];
            this.mineField = mineField;
            graph = new Graph();    
        }
        #endregion

        #region method

        public void drawMineSquare()
        {
            int x = 0;
            int y = 0;
            for (posRow = 0; posRow < Constant.MapRow; posRow++)
            {
                for (posColume = 0; posColume < Constant.MapColume; posColume++)
                {
                    Button button = new Button()
                    {
                        Width = Constant.TileWidth,
                        Height = Constant.TileHeight,
                        Location = new Point(x, y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };
                    tile[posRow, posColume] = new Tile(button, posRow, posColume, this);
                    mineField.Controls.Add(tile[posRow, posColume].getButton());
                    x += Constant.TileWidth;
                }
                x = 0;
                y += Constant.TileHeight;
            }

            fillGraph();
            lshape = new Lshape(this);
            lpiece = new LongPiece(this);
            beegboi = new BeegBoi(this);
            spiece = new ShortPiece(this);
            squareAttack = new SquareAttack(this);
            starAttack = new StarAttack(this);

        }

        public void formShipAction()
        {
            for (posRow = 0; posRow < Constant.MapRow; posRow++)
            {
                for (posColume = 0; posColume < Constant.MapColume; posColume++)
                {
                    tile[posRow, posColume].formShipAction();
                }
            }
        }

        public void removeShipAction()
        {
            for(posRow = 0; posRow < Constant.MapRow; posRow++)
            {
                for(posColume = 0; posColume < Constant.MapColume; posColume++)
                {
                    tile[posRow, posColume].removeShipAction();
                }
            }
        }

        public void formSkillAction()
        {
            for (posRow = 0; posRow < Constant.MapRow; posRow++)
            {
                for (posColume = 0; posColume < Constant.MapColume; posColume++)
                {
                    tile[posRow, posColume].formSkillAction();
                }
            }
        }
        public bool attack()
        {
            for (posRow = 0; posRow < Constant.MapRow; posRow++)
            {
                for (posColume = 0; posColume < Constant.MapColume; posColume++)
                {

                    if(tile[posRow, posColume].attack())
                    {
                        return true;
                    }

                }
            }
            return false;   
        }


        public void drawPart(int row, int colume)
        {
            tile[row, colume].isShip(true);
        }

        public Tile getTile(int row, int colume)
        {
            return tile[row, colume];
        }

        public void reset(int row, int colume)
        {
            tile[row, colume].isShip(false);
        }

        public void setSignal(int signal)
        {
            signalReceive = signal;
        }

        public int getSignal()
        {
            return signalReceive;
        }

        public IShip getShip()
        { 
            if (signalReceive == Constant.LshapeID)
                return lshape;
            if (signalReceive == Constant.LongPieceID)
                return lpiece;
            if (signalReceive == Constant.BeegBoiID)
                return beegboi;
            if (signalReceive == Constant.ShortPieceID)
                return spiece;
            return null;
        }

        public ISkill getSkill()
        {
            if (signalReceive == Constant.squareAtkID)
                return squareAttack;
            if (signalReceive == Constant.starAtkID)
                return starAttack;
            return null;
        }
        public Lshape getLshape()
        {
            return lshape;
        }

        public LongPiece getLpiece()
        {
            return lpiece;
        }

        public BeegBoi getBeegBoi()
        {
            return beegboi;
        }

        public ShortPiece getShortPiece()
        {
            return spiece;
        }

        public void fillGraph()
        {
            graph.addFieldVerticies(this);
            graph.addFieldEdge(this);
        }

        public Graph getGraph()
        {
            return graph;
        }
        #endregion
    }
}
