using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_DSA_Project
{
    public class ProgressManager
    {
        private int LshapeHP;
        private int LongHP;
        private int ShortHP;
        private int BeegboiHP;
        private int maxEnergy;
        private int currentEnergy;
        private String text;

        public ProgressManager(int maxEnergy, String text)
        {
            this.LshapeHP = Constant.LshapeHP;
            this.LongHP = Constant.LongHP;
            this.ShortHP = Constant.ShortHP;
            this.BeegboiHP = Constant.BeegBoiHP;
            this.maxEnergy = maxEnergy;
            this.currentEnergy = 20;
            this.text = text;
        }
        public void maxEnergyReduce(int amount)
        {
            maxEnergy -= amount;
        }
        public void currentEnergyReduce(int amount)
        {
            currentEnergy -= amount;
        }

        public void currentEnergyRaise(int amount)
        {
            currentEnergy += amount;
        }
        public void LshapeHPReduce()
        {
            LshapeHP--;
        }
        public void LongHPReduce()
        {
            LongHP--;
        }
        public void ShortHPReduce()
        {
            ShortHP--;
        }
        public void BeegBoiHPReduce()
        {
            BeegboiHP--;
        }
        public int getMaxEnergy()
        {
            return maxEnergy;
        }
        public int getCurrentEnergy()
        {
            return currentEnergy;
        }
        public int getLongHP()
        {
            return LongHP;
        }
        public int getLShapeHP()
        {
            return LshapeHP;
        }
        public int getBeegBoiHP()
        {
            return BeegboiHP;
        }
        public int getShortHP()
        {
            return ShortHP;
        }
        public void anounce()
        {
            if (LshapeHP + ShortHP + LongHP + BeegboiHP == 0)
            {
                System.Windows.Forms.MessageBox.Show(text);
            }
        }
    }
}
