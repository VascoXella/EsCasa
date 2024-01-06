using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCasa.Properties
{
    internal class Vector
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector()
        {
        }

        public Vector(float X, float Y)
        {
            x = X;
            y = Y;
        }


        public static Vector Parser(string a)
        {
            Vector V = new Vector();

            a.Split();
            string[] ss = a.Split(';');
            foreach (string k in ss)
            {
                V.x = (float)float.Parse(Console.ReadLine());
                V.y = (float)float.Parse(Console.ReadLine());
            }
            return V;
        }

        public Vector Sommav(Vector v2)
        {
            Vector V = new Vector();
            V.x = this.x + v2.x;
            V.y = this.y + v2.y;
            return V;
        }

    }
}