using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        

        {
              Console.WriteLine("Hello! Let's learn your squares and cubes");//Prompting the user to enter an integer. 

            string Continue = Console.ReadLine();

            do
            {

                Console.WriteLine("Enter an integer.");

                // Declaring varibles
                int number = int.Parse(Console.ReadLine()); //Any integer that the user types in will be stored here.

                // Format of the table
                Console.WriteLine("Number       " + "Squared      " + "Cubed");
                Console.WriteLine("======       " + "=======      " + "======");

                // The logic which is the For loop.
                for (int i = 1; i <= number; i++)
                {
                   Console.WriteLine("{0}              {1}            {2}", i, Math.Pow(i, 2), Math.Pow(i, 3)); //Tells the computer when a user types a number to use a power.
                }

                    Console.WriteLine("Would you like to continue? (y/n");
                    Continue = Console.ReadLine().ToLower();
                
            } while (Continue == "y" || Continue == "yes");

            
            

            









        }
    }
}
