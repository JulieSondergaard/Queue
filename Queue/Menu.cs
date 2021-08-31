using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Menu
    {
        //GetMenu is the whole method for the menu
        public static void GetMenu()
        {
            string header = "";
            string headerSpace = "";

            for (int i = 0; i < 50; i++)
            {
                header += "=";
                if (i % 4 == 0)
                {
                    headerSpace += " ";
                }

            }
            Console.WriteLine(header);
            Console.WriteLine($"{headerSpace} Discoteque Uh la la ");
            Console.WriteLine(header);
            Console.WriteLine();
            Console.WriteLine("1. Add guests");
            Console.WriteLine();
            Console.WriteLine("2. Send guest(s) home");
            Console.WriteLine();
            Console.WriteLine("3. Show the number of guests on the guestlist");
            Console.WriteLine();
            Console.WriteLine("4. Show min and max guests");
            Console.WriteLine();
            Console.WriteLine("5. Find a specific guest");
            Console.WriteLine();
            Console.WriteLine("6. Print all guests");
            Console.WriteLine();
            Console.WriteLine("7. Exit");
            Console.WriteLine();
            Console.WriteLine();
        }

        //TryAgain gives the user the chance to go back to the menu again
        public static void TryAgain()
        {
            Console.WriteLine("Do you want to go back to the menu? Yes or No?");
            string input = Console.ReadLine();
            if (input == "yes" || input == "Yes")
            {
                Program.repeat = true;
                
            }
            else if (input == "no" || input == "No")
            {
                Console.WriteLine("The program is being closed when you press enter.");
                Console.WriteLine();
                Console.ReadLine();
                Environment.Exit(0);
            }

        }

        public Menu()
        {

        }

    }
}
