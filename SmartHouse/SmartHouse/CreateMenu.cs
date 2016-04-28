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
                        EquipmentMenu.CreateLamp();
                        break;
                    case 2:
                        EquipmentMenu.CreateRadio();
                        break;
                    case 3:
                        EquipmentMenu.CreateConditioner();
                        break;
                    case 4:
                        EquipmentMenu.CreateBoiler();
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