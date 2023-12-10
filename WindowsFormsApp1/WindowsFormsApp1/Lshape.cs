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
        private int state = 4;
        private MineFieldManager fieldManager;
        private Boolean canDrawH = false; // be able to draw horizontally
        private Boolean canDrawV = false; // be able to draw vertically

        public Lshape(Tile tile, MineFieldManager fieldManager)
        {
            this.tile = tile;
            this.fieldManager = fieldManager;
        }

        public int getState()
        {
            return state;
        }

        public Boolean getDrew()
        {
            return drew;
        }

        public void setState(int input)
        {
            state = input;
        }

        public Boolean getPermission()
        {
            if (canDrawH == false || canDrawV == false)
                return false;
            return true;
        }

        public void drawPart()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getPosRow(), tile.getPosColume() - i,Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getPosRow() - i, tile.getPosColume(),Constant.LshapeID);
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getPosRow() - i, tile.getPosColume(),Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getPosRow(), tile.getPosColume() + i,Constant.LshapeID);
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getPosRow(), tile.getPosColume() + i, Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getPosRow() + i, tile.getPosColume(), Constant.LshapeID);
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.drawPart(tile.getPosRow() + i, tile.getPosColume(), Constant.LshapeID);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.drawPart(tile.getPosRow(), tile.getPosColume() - i, Constant.LshapeID);
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
            if((tile.getPosColume() - Constant.LshapeV >= 0-1) && (tile.getPosRow() - Constant.LshapeH >= 0-1) && state == 1)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if(fieldManager.getTile(tile.getPosRow(),tile.getPosColume()-i).getType() == 0 || fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume()-i).getType() != 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow()-i, tile.getPosColume()).getType() == 0 || fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() == 1)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow()-i, tile.getPosColume()).getType() != 0 && fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() != 1)
                    {
                        canDrawH = false;
                        break;
                    }
                }
            }
            if ((tile.getPosColume() + Constant.LshapeH <= Constant.MapColume && tile.getPosRow() - Constant.LshapeV >= 0-1) && state == 2)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow()-i, tile.getPosColume()).getType() == 0 || fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow()-i, tile.getPosColume()).getType() != 0 && fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() == 0 || fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() == Constant.LshapeID)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() != 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() != Constant.LshapeID)
                    {
                        canDrawH = false;
                        break;
                    }
                }
            }
            if ((tile.getPosColume() + Constant.LshapeV <= Constant.MapColume && tile.getPosRow() + Constant.LshapeH <= Constant.MapRow) && state == 3)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume()+i).getType() == 0 || fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume()+i).getType() != 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow()+i, tile.getPosColume()).getType() == 0 || fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() == Constant.LshapeID)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow()+i, tile.getPosColume()).getType() != 0 && fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() != Constant.LshapeID)
                    {
                        canDrawH = false;
                        break;
                    }
                }
            }
            if ((tile.getPosColume() - Constant.LshapeH >= 0-1 && tile.getPosRow() + Constant.LshapeV <= Constant.MapRow) && state == 4)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow()+i, tile.getPosColume()).getType() == 0 || fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() == Constant.LshapeID)
                    {
                        canDrawV = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow()+i, tile.getPosColume()).getType() != 0 && fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() != Constant.LshapeID)
                    {
                        canDrawV = false;
                        break;
                    }
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume()-i).getType() == 0 || fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() == Constant.LshapeID)
                    {
                        canDrawH = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume()-i).getType() != 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() != Constant.LshapeID)
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
                    tile.reset(tile.getPosRow(), tile.getPosColume() - i);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getPosRow() - i, tile.getPosColume());
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.reset(tile.getPosRow() - i, tile.getPosColume());
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getPosRow(), tile.getPosColume() + i);
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.reset(tile.getPosRow(), tile.getPosColume() + i);
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getPosRow() + i, tile.getPosColume());
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.LshapeV; i++)
                {
                    tile.reset(tile.getPosRow() + i, tile.getPosColume());
                }
                for (int i = 1; i < Constant.LshapeH; i++)
                {
                    tile.reset(tile.getPosRow(), tile.getPosColume() - i);
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
