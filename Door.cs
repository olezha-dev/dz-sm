using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class Door: GameObject, IInteractable
    {
        private bool requiredAccess;

        public Door(string name, bool requiredAccess) : base(name)
        {
            this.requiredAccess = requiredAccess;
        }
        public string iteractik(Player player)
        {
            if (player.HasAccessCard == requiredAccess)
            {
                return "Door opened";
            }
            else
            {
                return "Access denied";
            }
        }

        public override string Info()
        {
             return $"Door: {Name}, Active: {IsActive}";
        }
    }
}
