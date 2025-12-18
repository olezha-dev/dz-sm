using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class Button : GameObject, IInteractable
    {
        private ITriggerable target;
        public Button(string name, ITriggerable target) : base("батончик твикс")
        {
            this.target = target;
        }

        public string Interact(Player player)
        {
            target.Trigger();
            return "";
        }
        public override string Info()
        {
            return $"Батон: {Name}, активный?: {IsActive}";
        }
    }
}
