using System;

namespace SmartHouse
{
    internal class MainMenu
    {
        public static void ChoiceMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Create object.");
            Console.WriteLine("2. Object Preview.");
            Console.WriteLine("3. Modify objecst.");
            Console.WriteLine("4. Remove objects.");
            Console.WriteLine("5. Quit programm.");
            Console.Write("\n:");

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
                        StatusMenu.ViewObjects();
                        StatusMenu.BackMainMenu();
                        break;
                    case 3:
                        PropertyMenu.SelectionId();
                        break;
                    case 4:
                        DeleteMenu.SelectionId();
                        break;
                    case 5:

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
