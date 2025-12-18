using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    internal abstract class GameObject
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; private set; }
        public GameObject(string name)
        {
            Name = name;
            IsActive = true;
            int Id = 0;
        }
        public void Enable()
        {
            IsActive = true;
        }
        public void Disable()
        {
            IsActive = false;
        }
        public abstract string Info();
    }
}
