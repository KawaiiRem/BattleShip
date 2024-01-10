using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class StarAttack: ISkill
    {
        private MineFieldManager fieldManager;
        private Tile tile;
        private Boolean drew = false;
        public StarAttack(MineFieldManager fieldManager)
        {
            this.fieldManager = fieldManager;
        }

        public void resetView()
        {
            if (tile.getPosRow() + 1 < Constant.MapRow && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).reDraw();
            if (tile.getPosRow() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).reDraw();
            if (tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).reDraw();
            if (tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).reDraw();
            if (tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).reDraw();
            if (tile.getPosRow() - 1 >= 0 && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).reDraw();
            if (tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).reDraw();
            if (tile.getPosRow() - 1 >= 0 && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).reDraw();
            fieldManager.getTile(tile.getPosRow(), tile.getPosColume()).reDraw();

            if (tile.getPosRow() + 2 < Constant.MapRow && fieldManager.getTile(tile.getPosRow() + 2, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 2, tile.getPosColume()).reDraw();
            if (tile.getPosRow() - 2 >= 0 && fieldManager.getTile(tile.getPosRow() - 2, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 2, tile.getPosColume()).reDraw();
            if (tile.getPosColume() + 2 < Constant.MapColume && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 2).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 2).reDraw();
            if (tile.getPosColume() - 2 >= 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 2).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 2).reDraw();
            drew = false;
        }

        public void review()
        {
            if (tile.getPosRow() + 1 < Constant.MapRow && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosRow() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosRow() - 1 >= 0 && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosRow() - 1 >= 0 && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).getButton().BackColor = System.Drawing.Color.Red;
            fieldManager.getTile(tile.getPosRow(), tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red;

            if (tile.getPosRow() + 2 < Constant.MapRow && fieldManager.getTile(tile.getPosRow() + 2, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 2, tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosRow() - 2 >= 0 && fieldManager.getTile(tile.getPosRow() - 2, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 2, tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosColume() + 2 < Constant.MapColume && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 2).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 2).getButton().BackColor = System.Drawing.Color.Red;
            if (tile.getPosColume() - 2 >= 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 2).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 2).getButton().BackColor = System.Drawing.Color.Red;
            drew = true;
        }

        public void attack()
        {
            if (tile.getPosRow() + 1 < Constant.MapRow && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).attack();
            if (tile.getPosRow() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).attack();
            if (tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).attack();
            if (tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).attack();
            if (tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).attack();
            if (tile.getPosRow() - 1 >= 0 && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).attack();
            if (tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).attack();
            if (tile.getPosRow() - 1 >= 0 && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).attack();
            fieldManager.getTile(tile.getPosRow(), tile.getPosColume()).attack();

            if (tile.getPosRow() + 2 < Constant.MapRow && fieldManager.getTile(tile.getPosRow() + 2, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 2, tile.getPosColume()).attack();
            if (tile.getPosRow() - 2 >= 0 && fieldManager.getTile(tile.getPosRow() - 2, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 2, tile.getPosColume()).attack(); ;
            if (tile.getPosColume() + 2 < Constant.MapColume && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 2).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 2).attack();
            if (tile.getPosColume() - 2 >= 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 2).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 2).attack();
            drew = false;
        }

        public void setTile(Tile tile)
        {
            if (drew == true)
            {
                resetView();
            }
            this.tile = tile;
            review();
        }
    }
}
