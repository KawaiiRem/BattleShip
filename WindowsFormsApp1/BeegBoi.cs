using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BeegBoi:IShip
    {
        private Tile tile;
        private Boolean drew = false;
        private int state = 1;

        public BeegBoi(Tile tile)
        {
            this.tile = tile;
        }
        public void drawPart()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        tile.drawPart(tile.getCoordY() + i, tile.getCoordX() + j,Constant.BeegBoiID);
                    }
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.drawPart(tile.getCoordY() + i, tile.getCoordX() - j, Constant.BeegBoiID);
                    }
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        tile.drawPart(tile.getCoordY() - i, tile.getCoordX() - j, Constant.BeegBoiID);
                    }
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.drawPart(tile.getCoordY() - i, tile.getCoordX() + j, Constant.BeegBoiID);
                    }
                }
            }
            drew = true;
        }

        public void detect()
        {
            if ((tile.getCoordX() + Constant.BeegBoiH > Constant.MapColume || tile.getCoordY() + Constant.BeegBoiV > Constant.MapRow) && state == 1)
            {
                shiftState();
                detect();
            }

            if ((tile.getCoordX() - Constant.BeegBoiV < 0 || tile.getCoordY() + Constant.BeegBoiH > Constant.MapRow) && state == 2)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordX() - Constant.BeegBoiH < 0 || tile.getCoordY() - Constant.BeegBoiV < 0) && state == 3)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordX() + Constant.BeegBoiV > Constant.MapColume || tile.getCoordY() - Constant.BeegBoiH < 0) && state == 4)
            {
                shiftState();
                detect();
            }
        }

        public void reset()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        tile.reset(tile.getCoordY() + i, tile.getCoordX() + j);
                    }
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.reset(tile.getCoordY() + i, tile.getCoordX() - j);
                    }
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        tile.reset(tile.getCoordY() - i, tile.getCoordX() - j);
                    }
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.reset(tile.getCoordY() - i, tile.getCoordX() + j);
                    }
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
