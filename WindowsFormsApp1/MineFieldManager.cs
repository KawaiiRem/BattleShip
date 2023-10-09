using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MineSweaper
{
    public class MineFieldManager
    {
        #region properties
        private Panel mineField;
        private int posRow;
        private int posColume;
        private static Tile[,] tile;
        private Lshape lshape;
        private LongPiece lpiece;
        private BeegBoi beegboi;
        private ShortPiece spiece;
        private int signalReceive;
        #endregion

        #region initiate 
        public MineFieldManager(Panel mineField)
        {
            tile = new Tile[Constant.MapRow + 4, Constant.MapColume + 4];
            this.mineField = mineField;
        }
        #endregion

        #region method

        public void setSignal(int signal)
        {
            signalReceive = signal;
        }
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
                    tile[posRow, posColume] = new Tile(button, posColume, posRow, this);
                    mineField.Controls.Add(tile[posRow, posColume].getButton());
                    x += Constant.TileWidth;
                }
                x = 0;
                y += Constant.TileHeight;
            }
            Button sele1 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 100),
                BackColor = Color.Violet,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow, Constant.MapColume] = new Tile(sele1, 100, 100, this);
            lshape = new Lshape(tile[Constant.MapRow, Constant.MapColume]);

            Button sele2 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 200),
                BackColor = Color.Blue,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow + 1, Constant.MapColume + 1] = new Tile(sele2, 100, 100, this);
            lpiece = new LongPiece(tile[Constant.MapRow + 1, Constant.MapColume + 1]);

            Button sele3 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 300),
                BackColor = Color.Blue,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow + 2, Constant.MapColume + 2] = new Tile(sele3, 100, 100, this);
            beegboi = new BeegBoi(tile[Constant.MapRow + 2, Constant.MapColume + 2]);

            Button sele4 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 300),
                BackColor = Color.Blue,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow + 3, Constant.MapColume + 3] = new Tile(sele4, 100, 100, this);
            spiece = new ShortPiece(tile[Constant.MapRow + 3, Constant.MapColume + 3]);
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
            return lshape;
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
        #endregion
    }
}
