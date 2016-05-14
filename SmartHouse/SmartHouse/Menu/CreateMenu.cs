using System;

namespace SmartHouse
{
    internal class CreateMenu
    {
        public static void SelectionObjectType()
        {
            Console.Clear();
            Console.WriteLine("Select object type");
            Console.WriteLine("1. Lamp.");
            Console.WriteLine("2. Radio.");
            Console.WriteLine("3. Conditioner.");
            Console.WriteLine("4. Boiler.");
            Console.WriteLine("5. Main Menu.");
            Console.Write("\n:  ");

            int choice = 0;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Home.AddToList(new Lamp());    
                        Console.WriteLine("lamp successfully created\nPress Enter to continue");
                        break;
                    case 2:
                        Home.AddToList(new Radio());    
                        Console.WriteLine("Radio successfully created\nPress Enter to continue");
                        break;
                    case 3:
                        Home.AddToList(new Conditioner());
                        Console.WriteLine("Conditioner successfully created\nPress Enter to continue");
                        break;
                    case 4:
                        Home.AddToList(new Boiler());
                        Console.WriteLine("Boiler successfully created\nPress Enter to continue");
                        break;
                    case 5:
                        MainMenu.ChoiceMenu();
                        break;
                    default:
                        Console.WriteLine("Incorrect input \nPress any key to continue");
                        Console.ReadLine();
                        MainMenu.ChoiceMenu();
                        break;
                }

                Console.ReadKey();
                MainMenu.ChoiceMenu();
            }
            else
            {
                Console.WriteLine("Incorrect input \nPress any key to continue");
                Console.ReadLine();
                MainMenu.ChoiceMenu();
            }
        }
    }
}