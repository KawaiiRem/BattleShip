using BattleShip_DSA_Project;
using MineSweaper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Resources
{
    public class MachineAction
    {
        private static int count = 0;
        private MineFieldManager fieldManager;
        private List<Vertex> tileToAttack;
        private Graph graph;
        private Random rand;
        private Boolean active;
        private int gear = 1;
        private Random random;
        public MachineAction(MineFieldManager fieldManager, Graph graph, Boolean active)
        {
            this.active = active;
            rand = new Random();
            tileToAttack = new List<Vertex>();
            this.fieldManager = fieldManager;
            this.graph = graph;
            random = new Random();
        }
        public Boolean getActive()
        {
            return active;
        }

        public void setShip()
        {
            Random rand = new Random();
            while ( !fieldManager.getLpiece().getDrew() 
                    || !fieldManager.getBeegBoi().getDrew() 
                    || !fieldManager.getLshape().getDrew() 
                    || !fieldManager.getShortPiece().getDrew()
                )
            {
                for (int type = 1; type <= 4; type++)
                {
                    for (int posRow = 1; posRow < Constant.MapRow-1; posRow += rand.Next(5))
                    {
                        for (int posColume = 1; posColume < Constant.MapColume-1; posColume += rand.Next(5))
                        {
                            if (fieldManager.getTile(posRow, posColume).getIsShip() == false && rand.Next(100) <= 2)
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
        
        public List<Vertex> getTileToAttack()
        {
            return tileToAttack;
        }

        public async void attack()
        {
            if(gear == 1)
            {
                Vertex vertex = fieldManager.getGraph().getRandVertex();
                fieldManager.getTile(vertex.getTile().getPosRow(), vertex.getTile().getPosColume()).attack();
                if (tileToAttack.Count > 0 && fieldManager.getProgress().getCurrentEnergy() == fieldManager.getProgress().getMaxEnergy())
                    gear = 3;
                else if (fieldManager.getProgress().getCurrentEnergy() == fieldManager.getProgress().getMaxEnergy())
                    gear = 2;
            }
            else if (gear == 2)
            {
                Vertex vertex = fieldManager.getGraph().getRandVertex();
                fieldManager.setSignal(rand.Next(5, 6));
                fieldManager.getSkill().setTile(fieldManager.getTile(vertex.getTile().getPosRow(), vertex.getTile().getPosColume()));
                fieldManager.getSkill().attack();
                if (fieldManager.getProgress().getCurrentEnergy() <= 30)
                    gear = 1;
            }
            else
            {
                fieldManager.setSignal(rand.Next(5, 6));
                fieldManager.getSkill().setTile(tileToAttack[rand.Next(0, tileToAttack.Count - 1)].getTile());
                fieldManager.getSkill().attack();
                if (tileToAttack.Count == 0 || fieldManager.getProgress().getCurrentEnergy() <= 30)
                    gear = 1;
            }

            await Task.Delay(2000);
            fieldManager.togglePanel();
        }
    }
}
