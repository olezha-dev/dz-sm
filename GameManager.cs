using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1прмоитльд
{
    internal class GameManager
    {
        private Settlement settlement;
        private int gameTime;
        public GameManager(Settlement settlement, int gameTime)
        {
            this.settlement = settlement;
            this.gameTime = gameTime;
        }

        public void SimulateProduction()
        {
            int p = settlement.GetTotal();
            int pr = gameTime * p;
            Console.WriteLine(p);
        }
    }
}
