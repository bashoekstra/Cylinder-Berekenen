using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cylinder berekenen");

            Console.Write("Voer de radius van de cylinder in: ");
            String RadiusString = Console.ReadLine();
            double radius = Convert.ToDouble(RadiusString);

            Console.Write("Voer de hoogte van de cylinder in: ");
            String HoogteString = Console.ReadLine();
            double Hoogte = Convert.ToDouble(HoogteString);

            double pi = 3.141592654;

            double volume = pi * radius * radius * Hoogte;
            double oppervlakte = 2 * pi * radius * (radius + Hoogte);

            Console.WriteLine("De cylinder's volume is: " + volume);
            Console.WriteLine("De cylinder's opervlakte is: " + oppervlakte);


            Console.ReadKey();
        }
    }
}
