using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    class Program
    {
        //A public static boolean variable set to false, being used in the do-while
        public static bool repeat = false;

        static void Main(string[] args)
        {
            //Making a new queue called guestList
            Queue<string> guestList = new Queue<string>();


            do
            {
                //Calling the menu from the menu class and getting inputs from the user
                Menu.GetMenu();
                int menuInput = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                //Switch that holds alle the menu outcome
                switch (menuInput)
                {
                    //Case 1 is adding items/guests to the list. Made it possible to add more than one guest at the time.
                    case 1:
                        {
                            Console.WriteLine("How many guests do you want to add?");
                            int amount = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter the name of the guest(s) you want to add.");
                            for (int i = 0; i < amount; i++)
                            {
                                guestList.Enqueue(Console.ReadLine());
                            }
                            Console.WriteLine();
                            Menu.TryAgain();
                            break;
                        }
                    //Case 2 is removing/deleting items/guests from the list, first in, first out. Made it possible to send more then one guest home at the time.
                    case 2:
                        {
                            Console.WriteLine("You have chosen do delete guest(s) from the queue. How many guest do you want to send home?");
                            int amount = int.Parse(Console.ReadLine());
                            for (int i = 0; i < amount; i++)
                            {
                                guestList.Dequeue();
                            }
                            
                            Console.WriteLine();
                            Menu.TryAgain();
                            break;
                        }
                    //Case 3 is showing the numbers of guests there is on the guestlist at the moment
                    case 3:
                        {
                            Console.WriteLine("You have chosen to show the numbers of guests on the guestlist.");
                            Console.WriteLine();                            
                            Console.WriteLine("The number of guest(s) on the list: " + guestList.Count());
                            Console.WriteLine();
                            Menu.TryAgain();
                            break;
                        }
                    //Case 4 is showing the which of the guest(name) there is the first and last, according to the alphabet
                    case 4:
                        {
                            Console.WriteLine("The first name on the list is (in alphabetical order) " + guestList.Min());
                            Console.WriteLine("The last name on the list is (in alphabetical order) " + guestList.Max());
                            Menu.TryAgain();
                            break;
                        }
                    //In Case 5 you can search for a specific guest and you will be told if the guest is on the list or not
                    case 5:
                        {
                            Console.WriteLine("Please specify which guest you want to find on the list. And press Enter.");
                            if (guestList.Contains(Console.ReadLine()))
                            {
                                Console.WriteLine("The guest is on the list.");
                            }
                            else
                            {
                                Console.WriteLine("The guest is not on the list.");
                            }
                            
                            Menu.TryAgain();
                            break;
                        }
                    //Case 6 shows all the guests on the guestlist at the moment
                    case 6:
                        {
                            Console.WriteLine("Guest(s) on the list:");
                            foreach (string guest in guestList)
                            {
                                Console.WriteLine(guest);
                            }
                            Menu.TryAgain();
                            break;
                        }
                    //Case 7 is made to exit when you hit Enter.
                    case 7:
                        {
                            Console.WriteLine("You have chosen to exit. Press Enter and the program vil shut down.");
                            Environment.Exit(0);
                            break;
                        }
                    //Default is telling the user that something went wrong and gives the user the chance to try again
                    default:
                        {
                            Console.WriteLine("Something went wrong.");
                            Menu.TryAgain();
                            break;
                        }
                }
            } while (repeat == true);
        }
    }
}
