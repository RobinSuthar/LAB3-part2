using System.Drawing;
using System.Xml.Linq;

namespace LAB3_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            double c;
            int d;
            string m;
            
            List<IAnimal> animlas = new List<IAnimal>();
            /////////////////////////////////////////////////
            /////////////---1---/////////////////////////////
            /////////////////////////////////////////////////
            Console.Write("PLEASE GIVE A NAME FOR THE DOG: ");
            a = Console.ReadLine();
            Console.Write("PLEASE GIVE A COLOUR FOR YOUR DOG ");
            b = Console.ReadLine();
            Console.Write("PLEASE GIVE HEIGHT OF YOUR DOG: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("PLEASE GIVE AGE OF YOUR DOG: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------STORED--------------");
            Dog dog0 = new Dog(a, b, c, d);
            dog0.Tostring();
            dog0.Eat();
            dog0.Cry();
            animlas.Add(dog0);
            //////////////////////////////////////////////////
            //////////////////---2-------/////////////////////
            //////////////////////////////////////////////////
            Console.WriteLine("------------------------------------");
            Console.Write("PLEASE GIVE A NAME FOR THE CAT: ");
            a = Console.ReadLine();
            Console.Write("PLEASE GIVE A COLOUR FOR YOUR CAT: ");
            b = Console.ReadLine();
            Console.Write("PLEASE GIVE HEIGHT OF YOUR CAT: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("PLEASE GIVE AGE OF YOUR CAT: ");
            d = int.Parse(Console.ReadLine());
            Cat cat0 = new Cat(a, b, c, d);
            Console.WriteLine("---------------STORED--------------");
            cat0.Tostring();
            cat0.Eat();
            cat0.Cry();
            animlas.Add(cat0);
            //////////////////////////////////////////////////
            //////////////////---3-------/////////////////////
            //////////////////////////////////////////////////
            int h;
            Console.Write("WOULD YOU LIKE TO ADD MORE CATS AND DOGS?\n y = yes / n = no ");
            m = Console.ReadLine();
            int i = 0;
            if (m == "y")
            {
                Console.Write("WONDERFULL!! How many would you like to add : ");
                h = int.Parse(Console.ReadLine());
                for (i = 0; i != h; i++) 
                {
                    Console.WriteLine("-----------------------------------");
                    Console.Write("PLEASE GIVE A NAME FOR THE DOG: ");
                    a = Console.ReadLine();
                    Console.Write("PLEASE GIVE A COLOUR FOR YOUR DOG ");
                    b = Console.ReadLine();
                    Console.Write("PLEASE GIVE HEIGHT OF YOUR DOG: ");
                    c = int.Parse(Console.ReadLine());
                    Console.Write("PLEASE GIVE AGE OF YOUR DOG: ");
                    d = int.Parse(Console.ReadLine());
                    Dog dogi = new Dog(a, b, c, d);
                    Console.WriteLine("---------------STORED--------------");
                    dogi.Tostring();
                    dogi.Eat();
                    dogi.Cry();
                    animlas.Add(dogi);
                    

                    Console.WriteLine("-----------------------------------");
                    Console.Write("PLEASE GIVE A NAME FOR THE CAT: ");
                    a = Console.ReadLine();
                    Console.Write("PLEASE GIVE A COLOUR FOR YOUR CAT: ");
                    b = Console.ReadLine();
                    Console.Write("PLEASE GIVE HEIGHT OF YOUR CAT: ");
                    c = int.Parse(Console.ReadLine());
                    Console.Write("PLEASE GIVE AGE OF YOUR CAT: ");
                    d = int.Parse(Console.ReadLine());
                    Cat cati = new Cat(a, b, c, d);
                    Console.WriteLine("---------------STORED--------------");
                    cati.Tostring();
                    cati.Eat();
                    cati.Cry();
                    animlas.Add(cati);
                }

                Console.WriteLine("WONDER FULL!!");

            } 
            Console.WriteLine("\n");
            Console.WriteLine("WELCOME TO THE LIST OF ANIMALS");
            Console.WriteLine("\n");
            foreach (IAnimal s in animlas)
            {
                Console.WriteLine(s.Name);

            }

            Console.WriteLine();

        }
    }
}
