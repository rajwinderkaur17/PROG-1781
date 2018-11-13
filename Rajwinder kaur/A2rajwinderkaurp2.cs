using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2rajwinderkaurp2
{
    class Program
    {
        static double sphere(double r, double p)
        {
            double sphere;
            sphere = 4 / 3 * p * r * r * r;
            return sphere;
        }
        static double sphere(double j, double h, double p)
        {
            double sphere;
            sphere = p * j * j * h;
            return sphere;
        }
        static int sphere(int l, int b, int h)
        {
            int sphere;
            sphere = l * b * h;
            return sphere;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1: sphere");
            Console.WriteLine("2: cylinder");
            Console.WriteLine("3:rectangle prism");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            if (y == 1)
            {
                Console.WriteLine("enter the value of radius");
                string u = Console.ReadLine();
                double r = double.Parse(u);
                double res;
                res = sphere(3.14, r);
                Console.WriteLine("volume of sphere is = " + res);
            }
            else if (y == 2)
            {
                Console.WriteLine("enter the value of radius");
                string i = Console.ReadLine();
                double j = double.Parse(i);
                Console.WriteLine("enter the value of height");
                string k = Console.ReadLine();
                double h = double.Parse(k);
                double res1;
                res1 = sphere(3.14, j, h);
                Console.WriteLine("volume of cylinder is = " + res1);
            }
            else if (y == 3)
            {
                Console.WriteLine("enter the length of rectangle ");
                string a = Console.ReadLine();
                int l = int.Parse(a);
                Console.WriteLine("enter the breadth of rectangle ");
                string c = Console.ReadLine();
                int b = int.Parse(c);
                Console.WriteLine("enter the height of rectangle ");
                string d = Console.ReadLine();
                int h = int.Parse(d);
                int result;
                result = sphere(l, b, h);
                Console.WriteLine("volume of rectanglen prism is = " + result);

            }
        }
    }
}
