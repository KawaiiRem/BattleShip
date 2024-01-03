using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IShip
    {
        void detect(Tile tile);
        void shiftState();
        void drawPart();    
        void reset();
        void setTile(Tile tile);
        int getState();
        Boolean getPermission();
        Boolean getDrew();
    }
}
