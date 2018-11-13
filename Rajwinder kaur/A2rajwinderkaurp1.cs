using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2rajwinderkaurp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, n;
            Console.WriteLine("Student's age");
            string ag = Console.ReadLine();
            double age = double.Parse(ag);

            Console.WriteLine("international student( yes or no )");
            string a = Console.ReadLine();
            Console.WriteLine("Registration semester(Fall , Winter or Summer)");
            string b = Console.ReadLine();


            if (a =="no")
            {
                if (age <= 18)
                {
                    m = 300 + (0.13 * 300);
                    Console.WriteLine("Base tution" + m);
                }
                else if (age <= 49)
                {
                    m = 500 + (0.13 * 500);
                    Console.WriteLine("Base tution" + m);
                }
                else
                {
                    m = 400 + (0.13 * 400);
                    Console.WriteLine("base tution" + m);
                }

            }
            else if (a == "yes")
            {
                if (age <= 18)
                {
                    m = 400 + (0.13 * 400);
                    Console.WriteLine("International student's fee $" + m);
                }
                else if (age <= 49)
                {
                    m = 600 + (0.13 * 600);
                    Console.WriteLine("international student's fee $" + m);
                }
                else
                {
                    m = 500 + (0.13 * 500);
                    Console.WriteLine("international student's fee $" + m);
                }
            }

            switch (b)
            {
                case "fall":
                    {
                        n = 250 + (0.13 * 250);
                        Console.WriteLine("Registration fees for semester is " + n);
                        double tax = 250 * 0.13;
                        Console.WriteLine("HST " + tax);
                        double total = n + tax;
                        Console.WriteLine("TOTAL: " + total);
                        break;
                    }
                case "winter":
                    {
                        n = 220 + (0.13 * 220);
                        Console.WriteLine("Registration fees for semester is " + n);
                        double tax = 220 * 0.13;
                        Console.WriteLine("HST " + tax);
                        double total = n + tax;
                        Console.WriteLine("TOTAL: " + total);
                        break;

                    }
                case "summer":
                    {
                        n = 150 + (0.13 * 150);
                        Console.WriteLine("Registration fees for semester is " + n);
                        double tax = 150 * 0.13;
                        Console.WriteLine("HST " + tax);
                        double total = n + tax;
                        Console.WriteLine("TOTAL: " + total);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid month");
                        break;
                    }
            }
        }
    }
}
