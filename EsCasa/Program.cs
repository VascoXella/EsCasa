using EsercizioCasa.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 2);

            Vector v2 = new Vector(3, 3);

            Vector v3 = new Vector();
            v3 = Vector.Parser("4; 4");


            Console.WriteLine("{0}, {1}", v1.Sommav(v2).x, v3.Sommav(v2).y);


            Console.ReadLine();
        }



    }
}
