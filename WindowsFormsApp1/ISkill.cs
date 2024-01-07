using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ISkill
    {
        void review();
        void resetView();
        void attack();
        void setTile(Tile tile);
    }
}
