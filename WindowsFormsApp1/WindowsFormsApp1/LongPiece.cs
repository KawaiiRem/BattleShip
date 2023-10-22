using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class LongPiece:IShip
    {
        private Tile tile;
        private Boolean drew = false;
        private int state = 1;
        private Boolean canDraw = false;
        private MineFieldManager fieldManager;

        public LongPiece(Tile tile, MineFieldManager fieldManager)
        {
            this.tile = tile;
            this.fieldManager = fieldManager;
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
            if(state == 1 && (tile.getCoordX() + Constant.LongL <= Constant.MapColume))
            {
                for(int i = 0; i < Constant.LongL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() == Constant.LongPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() + i).getType() != Constant.LongPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if(state == 2 && (tile.getCoordY() + Constant.LongL <= Constant.MapRow))
            {
                for(int i = 0; i <Constant.LongL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY()+i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() == Constant.LongPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY()+i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() + i, tile.getCoordX()).getType() != Constant.LongPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if(state == 3 && (tile.getCoordX() - Constant.LongL >= 0-1))
            {
                for(int i = 0; i<Constant.LongL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX()-i).getType() == 0 || fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() == Constant.LongPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY(), tile.getCoordX()-i).getType() != 0 && fieldManager.getTile(tile.getCoordY(), tile.getCoordX() - i).getType() != Constant.LongPieceID)
                    {
                        canDraw = false;
                        break;
                    }
                }
            }
            if(state == 4 && (tile.getCoordY() - Constant.LongL >= 0-1))
            {
                for(int i = 0; i<Constant.LongL; i++)
                {
                    if (fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() == 0 || fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() == Constant.LongPieceID)
                    {
                        canDraw = true;
                    }
                    if (fieldManager.getTile(tile.getCoordY()-i, tile.getCoordX()).getType() != 0 && fieldManager.getTile(tile.getCoordY() - i, tile.getCoordX()).getType() != Constant.LongPieceID)
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
