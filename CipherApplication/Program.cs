using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            int conversion = convertMethod(password);

            Console.WriteLine("Your password has been converted to " + conversion + ".");
            Console.ReadLine();
        }

        static int convertMethod(string password)
        {
            int conversion = 0;

            foreach (int value in password)
            {
                conversion = conversion + value;
            }

            return conversion;
        }
    }
}