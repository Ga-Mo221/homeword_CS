using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_interface
{
    internal class ANIMAL
    {
        private String Name;
        public String NAME { 
            set { this.Name = value; }
            get { return this.Name; }
        }

        public ANIMAL() { }

        public ANIMAL(String name)
        {
            this.Name = name;
        }
    }
}
