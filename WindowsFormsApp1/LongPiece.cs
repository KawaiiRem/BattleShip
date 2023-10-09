using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class LongPiece:IShip
    {
        private Tile tile;
        private Boolean drew = false;
        private int state = 1;

        public LongPiece(Tile tile)
        {
            this.tile = tile;
        }
        public void drawPart()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() + i,Constant.LongPieceID);
                }
            }
            if (state == 2)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.drawPart(tile.getCoordY() + i, tile.getCoordX(), Constant.LongPieceID);
                }
            }
            if (state == 3)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() - i, Constant.LongPieceID);
                }
            }
            if (state == 4)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.drawPart(tile.getCoordY() -i , tile.getCoordX(),Constant.LongPieceID);
                }
            }
            drew = true;
        }

        public void reset()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() + i);
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.reset(tile.getCoordY() + i, tile.getCoordX());
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() - i);
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.LongL; i++)
                {
                    tile.reset(tile.getCoordY() - i, tile.getCoordX());
                }
            }
        }

        public void shiftState()
        {
            state++;
            if (state == 5)
            {
                state = 1;
            }
            detect();
        }

        public void detect()
        {
            if ((tile.getCoordX() + Constant.LongL > Constant.MapColume) && state == 1)
            {
                shiftState();
                detect();
            }

            if ((tile.getCoordY() + Constant.LongL > Constant.MapRow) && state == 2)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordX() - Constant.LongL < 0) && state == 3)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordY() - Constant.LongL < 0) && state == 4)
            {
                shiftState();
                detect();
            }
        }

        public void setTile(Tile tile)
        {
            if (drew == true)
                reset();
            this.tile = tile;
            detect();
            drawPart();
        }
    }
}
