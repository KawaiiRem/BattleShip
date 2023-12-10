using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BeegBoi:IShip
    {
        private Tile tile;
        private Boolean drew = false;
        private int state = 1;
        private MineFieldManager fieldManager;
        private Boolean canDraw = false;
        public BeegBoi(Tile tile, MineFieldManager fieldManager)
        {
            this.tile = tile;
            this.fieldManager = fieldManager;
        }

        public int getState()
        {
            return state;
        }

        public void setState(int input)
        {
            state = input;
        }

        public Boolean getDrew()
        {
            return drew;
        }


        public Boolean getPermission()
        {
            return canDraw;
        }

        public void drawPart()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        tile.drawPart(tile.getPosRow() + i, tile.getPosColume() + j,Constant.BeegBoiID);
                    }
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.drawPart(tile.getPosRow() + i, tile.getPosColume() - j, Constant.BeegBoiID);
                    }
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        tile.drawPart(tile.getPosRow() - i, tile.getPosColume() - j, Constant.BeegBoiID);
                    }
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.drawPart(tile.getPosRow() - i, tile.getPosColume() + j, Constant.BeegBoiID);
                    }
                }
            }
            drew = true;
        }
     
        public void detect(Tile tile)
        {
            if((tile.getPosColume() + Constant.BeegBoiH <= Constant.MapColume && tile.getPosRow() + Constant.BeegBoiV <= Constant.MapRow) && state == 1)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        if(fieldManager.getTile(tile.getPosRow()+i,tile.getPosColume()+j).getType() == 0 || fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume() + j).getType() == Constant.BeegBoiID)
                        {
                            canDraw = true;
                        }
                        if(fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume() + j).getType() != 0 && fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume() + j).getType() != Constant.BeegBoiID)
                        {
                            canDraw = false;
                            break;
                        }
                    }
                    if (canDraw == false)
                        break;
                }
            }
            if ((tile.getPosColume() - Constant.BeegBoiV >= 0-1 && tile.getPosRow() + Constant.BeegBoiH <= Constant.MapRow) && state == 2)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        if (fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume() - j).getType() == 0 || fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume() - j).getType() == Constant.BeegBoiID)
                        {
                            canDraw = true;
                        }
                        if (fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume() - j).getType() != 0 && fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume() - j).getType() != Constant.BeegBoiID)
                        {
                            canDraw = false;
                            break;
                        }
                    }
                    if (canDraw == false)
                        break;
                }
            }
            if ((tile.getPosColume() - Constant.BeegBoiH >= 0-1 && tile.getPosRow() - Constant.BeegBoiV >= 0-1) && state == 3)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        if (fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() - j).getType() == 0 || fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() - j).getType() == Constant.BeegBoiID)
                        {
                            canDraw = true;
                        }
                        if (fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() - j).getType() != 0 && fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() - j).getType() != Constant.BeegBoiID)
                        {
                            canDraw = false;
                            break;
                        }
                    }
                    if (canDraw == false)
                        break;
                }
            }
            if ((tile.getPosColume() + Constant.BeegBoiV <= Constant.MapColume && tile.getPosRow() - Constant.BeegBoiH >= 0-1) && state == 4)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        if (fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() + j).getType() == 0 || fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() + j).getType() == Constant.BeegBoiID)
                        {
                            canDraw = true;
                        }
                        if (fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() + j).getType() != 0 && fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume() + j).getType() != Constant.BeegBoiID)
                        {
                            canDraw = false;
                            break;
                        }
                    }
                    if (canDraw == false)
                        break;
                }
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
                        tile.reset(tile.getPosRow() + i, tile.getPosColume() + j);
                    }
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.reset(tile.getPosRow() + i, tile.getPosColume() - j);
                    }
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.BeegBoiV; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiH; j++)
                    {
                        tile.reset(tile.getPosRow() - i, tile.getPosColume() - j);
                    }
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.BeegBoiH; i++)
                {
                    for (int j = 0; j < Constant.BeegBoiV; j++)
                    {
                        tile.reset(tile.getPosRow() - i, tile.getPosColume() + j);
                    }
                }
            }
            drew = false;
        }

        public void shiftState()
        {
            canDraw = false;
            detect(tile);
            if (canDraw == true)
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

        public void setTile(Tile tile)
        {
            canDraw = false;
            detect(tile);
            if (canDraw == true)
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
