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
        private MineFieldManager fieldManager;
        private Boolean canDrawH = false;
        private Boolean canDrawV = false;

        public Lshape(Tile tile, MineFieldManager fieldManager)
        {
            this.tile = tile;
            this.fieldManager = fieldManager;
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
            canDrawH = false;
            canDrawV = false;
            detect(tile);
            if (canDrawV == true && canDrawH == true)
            {
                if (drew == true)
                    reset();
                state++;
                if (state == 5)
                {
                    state = 1;
                }
            }
        }
        public void detect(Tile tile)
        {
            if((tile.getCoordX() - Constant.LshapeV >= 0-1 && tile.getCoordY() - Constant.LshapeH >= 0-1) && state == 1)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if(fieldManager.getTile(tile.getCoordY(),tile.getCoordX()-i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX()-i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY()-i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() == 1)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY()-i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() != 1)
                    {
                        canDrawH = false;
                        break;
                    }
                }
            }
            if ((tile.getCoordX() + Constant.LshapeH <= Constant.MapColume && tile.getCoordY() - Constant.LshapeV >= 0-1) && state == 2)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY()-i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY()-i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() == Constant.LshapeID)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() != Constant.LshapeID)
                    {
                        canDrawH = false;
                        break;
                    }
                }
            }
            if ((tile.getCoordX() + Constant.LshapeV <= Constant.MapColume && tile.getCoordY() + Constant.LshapeH <= Constant.MapRow) && state == 3)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX()+i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX()+i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY()+i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() == Constant.LshapeID)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY()+i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() != Constant.LshapeID)
                    {
                        canDrawH = false;
                        break;
                    }
                }
            }
            if ((tile.getCoordX() - Constant.LshapeH >= 0-1 && tile.getCoordY() + Constant.LshapeV <= Constant.MapRow) && state == 4)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY()+i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY()+i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX()-i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() == Constant.LshapeID)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX()-i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() != Constant.LshapeID)
                    {
                        canDrawH = false;
                        break;
                    }
                }
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
            drew = false;
        }

        public void setTile(Tile tile)
        {
            canDrawH = false;
            canDrawV = false;
            detect(tile);
            if (canDrawH == true && canDrawV == true)
            {
                if (drew == true)
                {
                    reset();
                }
                this.tile = tile;
                drawPart();
            }
        }
    }
}
