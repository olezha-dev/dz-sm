using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class Trap : GameObject, IInteractable, IDamageable
    {
        public int damage = 5;
        public Trap(string name, int damage) : base(name)
        {
            this.damage = damage;
        }
        public void Interact(Player player)
        {
            player.Hp = player.Hp - damage;
        }
        public void ApplyDamage(Player player)
        {
            Disable();
        }
        public override string Info()
        {
            return "ловит на ловушку";
        }
    }
}
