using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class Scene
    {
        public List<GameObject> Objects { get; private set; } = new List<GameObject>();
        public void PrintAll()
        {
            for (int i = 0; i < Objects.Count-1; i++)
            {
                Objects[i].Info();
            }
        }
        public void Tick(TimedTrap timedTrap)
        {
            for (int i = 0;i < Objects.Count - 1; i++)
            {
                if (Objects[i] is IUpdatable)
                {
                    timedTrap.Update();
                }
            }
        }
    }
}
