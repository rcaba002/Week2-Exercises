using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine("* CALCULATE THE AREA OF A SHAPE *");
            Console.WriteLine("*********************************");
            Console.WriteLine();

            Console.WriteLine("T - triangle         C  - circle");
            Console.WriteLine("S - square           R  - rectangle");
            
            chooseShape();

            Console.ReadLine();
        }

        static void chooseShape()
        {
            double A = 0;

            Console.WriteLine();
            Console.Write("What shape? ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "t")
            {
                A = areaOfTriangle();
                Console.WriteLine("The area = " + A);
            }
            else if (userInput == "c")
            {
                A = areaOfCircle();
                Console.WriteLine("The area = " + A); 
            }
            else if (userInput == "s")
            {
                A = areaOfSquare();
                Console.WriteLine("The area = " + A);
            }
            else if (userInput == "r")
            {
                A = areaOfRectangle();
                Console.WriteLine("The area = " + A);
            }
            else
            {
                Console.WriteLine("I did not understand your entry.");
                chooseShape();
            }
        }

        static double areaOfTriangle()
        {
            Console.Write("Enter base: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            int h = Convert.ToInt32(Console.ReadLine());
            double A = 0.5 * b * h;
            return A;
        }

        static double areaOfCircle()
        {
            Console.Write("Enter radius: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double A = Math.PI * Math.Pow(r, 2);
            return A;
        }

        static double areaOfSquare()
        {
            Console.Write("Enter length of side: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double A = Math.Pow(a, 2);
            return A;
        }

        static double areaOfRectangle()
        {
            Console.Write("Enter width: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            int h = Convert.ToInt32(Console.ReadLine());
            double A = w * h;
            return A;
        }
    }
}
