using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IShip
    {
        void detect();
        void shiftState();
        void drawPart();    
        void reset();
        void setTile(Tile tile);
    }
}
