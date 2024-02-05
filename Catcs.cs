using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_part2
{
    internal class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public double Age { get; set; }

        public Cat()
        {

        }
        public Cat(string a, string b, double c, double d)
        {
            Name = a;
            Colour = b;
            Height = c;
            Age = d;
        }

        public string Cry()
        {
            Console.WriteLine("Meow");
            return "Meow";
        }

        public void Eat()
        {
            string result =
            "Name: " + Name + "\n" +
            "Colour: " + Colour + "\n" +
            "Height: " + Height + "\n" +
            "Age: " + Age;
            Console.WriteLine(result);
            Console.WriteLine("CAT EATS MICE");
        }

        public virtual void Tostring()
        {
            Console.WriteLine($"INFORMATION\n"  +
                $"COLOUR: {Name}\n" +
               $"COLOUR: {Colour}\n" +
               $"HEIHT: {Height}\n" +
               $"AGE: {Age}\n");
        }




    }
}
