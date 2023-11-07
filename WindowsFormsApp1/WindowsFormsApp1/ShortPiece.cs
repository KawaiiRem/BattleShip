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

        public ShortPiece(Tile tile, MineFieldManager fieldManager)
        {
            this.tile = tile;
            this.fieldManager = fieldManager;
        }
        public void drawPart()
        {
            if (state == 1)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() + i, Constant.ShortPieceID);
                }
            }
            if (state == 2)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY() + i, tile.getCoordX(), Constant.ShortPieceID);
                }
            }
            if (state == 3)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY(), tile.getCoordX() - i, Constant.ShortPieceID);
                }
            }
            if (state == 4)
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    tile.drawPart(tile.getCoordY() - i, tile.getCoordX(), Constant.ShortPieceID);
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
            if (state == 1 && (tile.getCoordX() + Constant.ShortL <= Constant.MapColume))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() != Constant.ShortPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if (state == 2 && (tile.getCoordY() + Constant.ShortL <= Constant.MapRow))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() != Constant.ShortPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if (state == 3 && (tile.getCoordX() - Constant.ShortL >= 0 -1))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() != Constant.ShortPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if (state == 4 && (tile.getCoordY() - Constant.ShortL >= 0-1))
            {
                for (int i = 0; i < Constant.ShortL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() == Constant.ShortPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() != Constant.ShortPieceID)
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

