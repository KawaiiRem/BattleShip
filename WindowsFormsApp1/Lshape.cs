using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Lshape:IShip
    {
        private Tile tile;
        private Boolean drew = false;
        private int state = 1;

        public Lshape(Tile tile)
        {
            this.tile = tile;
        }
        public void drawPart()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() - i,Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getCoordY() - i, tile.getCoordX(),Constant.LshapeID);
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getCoordY() - i, tile.getCoordX(),Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() + i,Constant.LshapeID);
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() + i, Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getCoordY() + i, tile.getCoordX(), Constant.LshapeID);
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getCoordY() + i, tile.getCoordX(), Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() - i, Constant.LshapeID);
                }
            }

            drew = true;
        }

        public void shiftState()
        {
            state++;
            if(state == 5)
            {
                state = 1;
            }
        }

        public void detect()
        {
            if ((tile.getCoordX() - Constant.LshapeV < 0 || tile.getCoordY() - Constant.LshapeH < 0) && state == 1)
            {
                shiftState();
                detect();
            }

            if ((tile.getCoordX() + Constant.LshapeH > Constant.MapColume || tile.getCoordY() - Constant.LshapeV < 0) && state == 2)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordX() + Constant.LshapeV > Constant.MapColume || tile.getCoordY() + Constant.LshapeH > Constant.MapRow) && state == 3)
            {
                shiftState();
                detect();
            }
            if ((tile.getCoordX() - Constant.LshapeH < 0 || tile.getCoordY() + Constant.LshapeV > Constant.MapRow) && state == 4)
            {
                shiftState();
                detect();
            }
        }
        public void reset()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() - i);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getCoordY() - i, tile.getCoordX());
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.reset(tile.getCoordY() - i, tile.getCoordX());
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() + i);
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() + i);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getCoordY() + i, tile.getCoordX());
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.reset(tile.getCoordY() + i, tile.getCoordX());
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getCoordY(), tile.getCoordX() - i);
                }
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
