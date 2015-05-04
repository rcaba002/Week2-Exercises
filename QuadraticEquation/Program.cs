using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation Solver");
            Console.WriteLine();

            userInputs();
        }

        static void userInputs()
        {
            Console.Write("Value of a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Value of b: ");
            double b = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Value of c: ");
            double c = Convert.ToInt32(Console.ReadLine());

            formula(a, b, c);
            
            Console.Write("Perform another calculation (Y/N)? ");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (input == "y")
                userInputs();
            else System.Environment.Exit(1);
        }

        static void formula(double a, double b, double c)
        {
            double sqrtPart = b * b - 4 * a * c;
            double x, x1, x2;

            if (sqrtPart > 0)
            {
                x1 = (-b + System.Math.Sqrt(sqrtPart)) / (2 * a);

                x2 = (-b - System.Math.Sqrt(sqrtPart)) / (2 * a);

                Console.WriteLine("Two Real Solutions:{0,8:f4} or {1,8:f4}", x1, x2);
            }
            else if (sqrtPart < 0)
            {
                Console.WriteLine("The solutions are imaginary.");
            }
            else 
            {
                x = (-b + System.Math.Sqrt(sqrtPart)) / (2 * a);

                Console.WriteLine("One Real Solution:{0,8:f4}", x);
            }
        }
    }
}