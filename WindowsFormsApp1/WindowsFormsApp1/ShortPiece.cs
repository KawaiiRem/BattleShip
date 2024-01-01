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
        private MineFieldManager fieldManager;
        private Boolean canDraw = false;
        private int health = Constant.ShortL;

        public ShortPiece(Tile tile, MineFieldManager fieldManager)
        {
            this.tile = tile;
            this.fieldManager = fieldManager;
        }

        public void reduceHealth()
        {
            health--;
        }

        public Boolean alive()
        {
            if (health == 0)
                return false;
            return true;
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
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getPosRow(), tile.getPosColume() + i, Constant.ShortPieceID);
                }
            }
            if (state == 2)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getPosRow() + i, tile.getPosColume(), Constant.ShortPieceID);
                }
            }
            if (state == 3)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getPosRow(), tile.getPosColume() - i, Constant.ShortPieceID);
                }
            }
            if (state == 4)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getPosRow() - i, tile.getPosColume(), Constant.ShortPieceID);
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
                    tile.reset(tile.getPosRow(), tile.getPosColume() + i);
                }
            }

            if (state == 2)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.reset(tile.getPosRow() + i, tile.getPosColume());
                }
            }

            if (state == 3)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.reset(tile.getPosRow(), tile.getPosColume() - i);
                }
            }

            if (state == 4)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.reset(tile.getPosRow() - i, tile.getPosColume());
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
        
        public void detect(Tile tile) 
        {
            if (state == 1 && (tile.getPosColume() + Constant.ShortL <= Constant.MapColume))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() == 0 || fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() != 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + i).getType() != Constant.ShortPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if (state == 2 && (tile.getPosRow() + Constant.ShortL <= Constant.MapRow))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() == 0 || fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() != 0 && fieldManager.getTile(tile.getPosRow() + i, tile.getPosColume()).getType() != Constant.ShortPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if (state == 3 && (tile.getPosColume() - Constant.ShortL >= 0 -1))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() == 0 || fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() != 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - i).getType() != Constant.ShortPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if (state == 4 && (tile.getPosRow() - Constant.ShortL >= 0-1))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() == 0 || fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() != 0 && fieldManager.getTile(tile.getPosRow() - i, tile.getPosColume()).getType() != Constant.ShortPieceID)
                    {
                        canDraw = false;
                        break;
                    }
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

