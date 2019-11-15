using System;
using System.Collections.Generic;
using System.Text;

namespace provaGen
{
    class Animal
    {
        public string Name { get; set; }

        public int Legs { get; set; }

        public Animal(string name, int legs)
        {
            Name = name;
            this.Legs = legs;
        }

        public override string ToString()
        {
            return Name + " " + Legs;
        }
    }
}
