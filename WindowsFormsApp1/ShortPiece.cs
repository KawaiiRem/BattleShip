using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ShortPiece:IShip
    {
        private Tile tile;
        private Boolean drew = false;
        private int state = 1;

        public ShortPiece(Tile tile)
        {
            this.tile = tile;
        }
        public void drawPart()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() + i, Constant.ShortL);
                }
            }
            if (state == 2)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY() + i, tile.getCoordX(), Constant.ShortL);
                }
            }
            if (state == 3)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() - i, Constant.ShortL);
                }
            }
            if (state == 4)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY() - i, tile.getCoordX(), Constant.ShortL);
                }
            }
            drew = true;
        }

        public void reset()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() + i);
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.reset(tile.getCoordY() + i, tile.getCoordX());
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() - i);
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.ShortL; i++)
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
            if ((tile.getCoordX() + Constant.ShortL > Constant.MapColume) && state == 1)
            {
                shiftState();
                detect();
            }

            if ((tile.getCoordY() + Constant.ShortL > Constant.MapRow) && state == 2)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordX() - Constant.ShortL < 0) && state == 3)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordY() - Constant.ShortL < 0) && state == 4)
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

