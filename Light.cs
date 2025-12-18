using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal class Light : GameObject, ITriggerable
    {
        private bool isOn;

        public Light(string name) : base("")
        {
            isOn = false;
        }
        public void Trigger()
        {
            isOn = !isOn;
            Console.WriteLine("перекоючен");
        }
        public override string Info()
        {
            return $"Light: {Name}, активный ? {IsActive}, статус: {(isOn ? "On" : "Off")}";
        }
    }
}
