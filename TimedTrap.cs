using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class TimedTrap : Trap, IUpdatable
    {
        public int Delay;
        public TimedTrap(string name, int delay) : base(name, delay)
        {
            Delay = delay;
        }
        public void Update()
        {
            if (Delay == 0)
            {
                Enable();
            }
            Delay--;
        }
    }
}
