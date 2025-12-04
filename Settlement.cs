using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1прмоитльд
{
    internal class Settlement 
    {
        private Building[] buildings = new Building[5];
        private int budget;
        public Settlement(int budget)
        {
            this.budget = budget;
        }
        public void AddBuilding(Building building)
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] == null)
                {
                    if (budget >= building.BuildCost)
                    {
                        buildings[i] = building;
                        budget -= building.BuildCost;
                        Console.WriteLine($"Постройка {building.Name} добавлена.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Недостаточно средств для строительства {building.Name}.");
                        return;
                    }
                }
            }
        }
        public int GetTotalProduction()
        {
            int k = 0;
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null)
                {
                    k = k + 1;
                }
            }
            return k;
        }
        public int GetTotal()
        {
            int k = 1;
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null)
                {
                   int  propa =  buildings[i].Production;
                    k = k * propa;
                }
            }
            return k;
                
        }
        public void ShowBuildings()
        {
            for (int i = 0;i < buildings.Length; i++)
            {
                if (buildings[i] != null)
                {
                    buildings[i].DisplayInfo();
                }
            }
        }
    }

}
