using MineSweaper;
using System;
using System.ComponentModel;

namespace WindowsFormsApp1.Resources
{
    public class MachineAction
    {
        static int count = 0;
        private MineFieldManager fieldManager;
        private int[,] action = new int[Constant.MapRow, Constant.MapColume];

        public MachineAction(MineFieldManager fieldManager)
        {
            this.fieldManager = fieldManager;
        }

        public void setShip()
        {
            Random rand = new Random();
            while (!fieldManager.getLpiece().getDrew() || !fieldManager.getBeegBoi().getDrew() || !fieldManager.getLshape().getDrew() || !fieldManager.getShortPiece().getDrew())
            {
                for (int type = 1; type <= 4; type++)
                {
                    for (int posRow = 0; posRow < Constant.MapRow; posRow += 1)
                    {
                        for (int posColume = 0; posColume < Constant.MapColume; posColume += 1)
                        {
                            if (fieldManager.getTile(posRow, posColume).getIsShip() == false && rand.Next(100) <= 5)
                            {
                                switch (type)
                                {
                                    case 1:
                                        if (!checkDrew(fieldManager.getLshape()))
                                            fieldManager.getLshape().setTile(fieldManager.getTile(posRow, posColume));
                                        break;
                                    case 2:
                                        if (!checkDrew(fieldManager.getLpiece()))
                                            fieldManager.getLpiece().setTile(fieldManager.getTile(posRow, posColume));
                                        break;
                                    case 3:
                                        if (!checkDrew(fieldManager.getBeegBoi()))
                                            fieldManager.getBeegBoi().setTile(fieldManager.getTile(posRow, posColume));
                                        break;
                                    case 4:
                                        if (!checkDrew(fieldManager.getShortPiece()))
                                            fieldManager.getShortPiece().setTile(fieldManager.getTile(posRow, posColume));
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
                count++;
                Console.WriteLine(count);
            }
        }

        public Boolean checkDrew(IShip ship)
        {
            return ship.getDrew();
        }
        
        public void attack()
        {

        }
    }
}
