using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilFiveElevenTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double b;
                double h;


                Console.WriteLine("Enter your base length: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height: ");
                h = Convert.ToDouble(Console.ReadLine());

                double area = Program.calcArea(b, h);
                Console.WriteLine(area);
                Console.ReadLine();
            }
        }
        public static double calcArea(double b, double h)
        {
            return 0.5 * b * h;
        }









// triangle two starts here - but doesn't work
/*
            double bb;
            double hh;

            Console.WriteLine("Enter your basebase length :");
            bb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Enter your heightheight);
            hh = Convert.ToDouble(Console.ReadLine());
            double area = Program.calcArea(bb, hh);
            Console.WriteLine(area);
            Console.ReadLine();
        
    }
    public static double calcArea(double bb, double hh)
    {
        return 0.5 * bb * hh * 37
    }

    */


        }
    }
}
