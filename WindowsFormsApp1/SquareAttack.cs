using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SquareAttack: ISkill
    {
        private MineFieldManager fieldManager;
        private Tile tile;
        private Boolean drew = false;
        public SquareAttack(MineFieldManager fieldManager)
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
            drew = false;
        }

        public void review()
        {
           if(tile.getPosRow() + 1 < Constant.MapRow && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red;
           if(tile.getPosRow() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red;
           if(tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() + 1).getButton().BackColor = System.Drawing.Color.Red;
           if(tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume() - 1).getButton().BackColor = System.Drawing.Color.Red;
           if(tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() + 1).getButton().BackColor = System.Drawing.Color.Red;
           if(tile.getPosRow() - 1 >= 0 && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() - 1).getButton().BackColor = System.Drawing.Color.Red;
           if(tile.getPosRow() + 1 < Constant.MapRow && tile.getPosColume() - 1 >= 0 && fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() + 1, tile.getPosColume() - 1).getButton().BackColor = System.Drawing.Color.Red;
           if(tile.getPosRow() - 1 >= 0 && tile.getPosColume() + 1 < Constant.MapColume && fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow() - 1, tile.getPosColume() + 1).getButton().BackColor = System.Drawing.Color.Red;
           fieldManager.getTile(tile.getPosRow(), tile.getPosColume()).getButton().BackColor = System.Drawing.Color.Red; 
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
            if(fieldManager.getTile(tile.getPosRow(), tile.getPosColume()).getButton().Enabled == true)
                fieldManager.getTile(tile.getPosRow(), tile.getPosColume()).attack();
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
