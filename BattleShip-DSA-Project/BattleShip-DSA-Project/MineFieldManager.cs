﻿using System;
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
        private int signalReceive = 0;
        private Graph graph;
        #endregion

        #region initiate 
        public MineFieldManager(Panel mineField)
        {
            tile = new Tile[Constant.MapRow + 4, Constant.MapColume+1];
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

            Button sele1 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 100),
                BackColor = Color.Violet,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow, Constant.MapColume] = new Tile(sele1, 100, 100, this);
            lshape = new Lshape(tile[Constant.MapRow, Constant.MapColume],this);

            Button sele2 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 200),
                BackColor = Color.Blue,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow + 1, Constant.MapColume] = new Tile(sele2, 100, 100, this);
            lpiece = new LongPiece(tile[Constant.MapRow + 1, Constant.MapColume],this);

            Button sele3 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 300),
                BackColor = Color.Blue,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow + 2, Constant.MapColume] = new Tile(sele3, 100, 100, this);
            beegboi = new BeegBoi(tile[Constant.MapRow + 2, Constant.MapColume],this);

            Button sele4 = new Button()
            {
                Width = Constant.TileWidth,
                Height = Constant.TileHeight,
                Location = new Point(500, 300),
                BackColor = Color.Blue,
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            tile[Constant.MapRow + 3, Constant.MapColume] = new Tile(sele4, 100, 100, this);
            spiece = new ShortPiece(tile[Constant.MapRow + 3, Constant.MapColume],this);
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

        public void fillGraph()
        {
            graph.addFieldVerticies(this);
            graph.addFieldEdge(this);
        }

        public void updateTiteState(int state)
        {
            for (posRow = 0; posRow < Constant.MapRow; posRow++)
            {
                for (posColume = 0; posColume < Constant.MapColume; posColume++)
                {

                    tile[posRow, posColume].setState(state);
                }
            }
        }

        public Graph getGraph()
        {
            return graph;
        }
        #endregion
    }
}