using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class Checkpoint : GameObject, IInteractable
    {
        public Checkpoint(string name) : base("Чекапоинт") { }
        public void iteractik(Player player)
        {
            player.LastCheckpointId = Id;
        }
        public override string Info()
        {
            return "ставит чекпоинт";
        }
    }
}
