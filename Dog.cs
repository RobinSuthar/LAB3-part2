using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_part2
{
    internal class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public double Age { get; set; }

        public Dog() { }
        public Dog(string a, string b,double c,double d)
        {
            Name = a;
            Colour = b;
            Height = c;
            Age = d;
        }

        public string Cry()
        {
            Console.WriteLine("Woof");
            return "Woof";
        }

        public void Eat()
        { 
            Console.WriteLine("DOG EATS MEAT");
        }

        public virtual void Tostring()
        {
            Console.WriteLine($"INFORMATION\n" +
               $"NAME: {Name}\n" +
               $"COLOUR: {Colour}\n" +
               $"HEIGHT: {Height}\n" +
               $"AGE: {Age}\n");
        }


    }
}
