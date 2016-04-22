using System;

namespace SmartHouse
{
    internal class PropertyMenu // Пока что только для лампочек
    {
        public static void SelectionId()
        {
            StatusMenu.ViewObjects();

            Console.WriteLine("Choice objects ID, to change property.\nPress M to go to Main Menu .");
            Console.Write("\n:");
            
            int id = 0;
            string input = Console.ReadLine();
            
            if (Int32.TryParse(input, out id))
            {
                if (Home.equipments[id] != null)
                {
                    PropertySelection(id);
                }
                else
                {
                    Console.WriteLine("Incorrect input \nPress any key to continue");
                    Console.ReadLine();
                    MainMenu.ChoiceMenu();
                }
            }
            else 
            { 
                MainMenu.ChoiceMenu();
            }
        }

        public static void PropertySelection(int id)
        {
            int choice = 0;
            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("Property list.");
                Console.WriteLine("1. Turn on or turn off.");
                Console.WriteLine("2. Change name.");
                Console.WriteLine("3. Change brightness.");
                Console.WriteLine("4. Back to previus menu.");
                Console.Write("\n:");

                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LampMenu.SetState(id);
                        break;
                    case 2:
                        Home.SetName(id);
                        break;
                    case 3:
                        LampMenu.SetBrightness(id);
                        break;
                    case 4:
                        SelectionId();
                        break;
                }
            }
        }
    }
}
