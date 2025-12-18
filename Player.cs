using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class Player
    {
        public int Hp;
        public bool HasAccessCard;
        public int LastCheckpointId;
        public Player(int hp, bool hasAccessCard)
        {
            Hp = hp;
            HasAccessCard = hasAccessCard;
            LastCheckpointId = -1;
        }
    }
}
