using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Table of Powers");

            string UserChoice = "";
            do
            {
                Console.WriteLine("\nPlease enter an integer");
                int Num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number\tSquared\t Cubed");

                for (int i = 1; i <= Num; i++)
                {
                    Console.WriteLine($"{i}\t{Math.Pow(i, 2)}\t {Math.Pow(i, 3)}");
                }

                do
                {

                    Console.Write("Would you like to try again? (Y/N) ");

                    UserChoice = Console.ReadLine();
                    if (UserChoice != "Y" && UserChoice != "N")
                    {
                        Console.WriteLine("Invalid Input. Please Write (Y/N)");
                    }
                } while (UserChoice != "Y" && UserChoice != "N");

            } while (UserChoice == "Y");
        } 
    }

}
