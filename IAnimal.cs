using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_part2
{
    internal interface IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public double Age { get; set; }

        public abstract void Eat();

        public string Cry();
        
    }
}
