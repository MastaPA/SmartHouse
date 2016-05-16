using System;
using SmartHouse.Eqipment;

namespace SmartHouse
{
    internal class MainMenu
    {
        public static void EntryPoint()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the SmartHouse!");
            Console.WriteLine("1. Settings.");
            Console.WriteLine("2. Exit.");
            Console.Write("\n:  ");

            int choice = 0;

            while (choice != 2)
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ChoiceMenu();
                            break;
                        case 2:
                            Console.WriteLine("Press any key to exit");
                            break;
                        default:
                            Console.WriteLine("You enter invalid value\nTry again");
                            break;
                    }
                }

                Console.ReadKey();
            }
        }
        
        public static void ChoiceMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Create object.");
            Console.WriteLine("2. Object Preview.");
            Console.WriteLine("3. Modify objecst.");
            Console.WriteLine("4. Remove objects.");
            Console.WriteLine("5. Quit programm.");
            Console.Write("\n:  ");

            int choice = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateMenu.SelectionObjectType();
                        break;
                    case 2:
                        Home.GetList();

                        Console.WriteLine("\nPress Enter to continue");
                        Console.ReadLine();
                        MainMenu.ChoiceMenu();
                        break;
                    case 3:
                        PropertyMenu.SelectionId();
                        break;
                    case 4:
                        DeleteMenu.SelectionId();
                        break;
                    case 5:
                        EntryPoint();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }   
    }
}
