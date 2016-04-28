using System;

namespace SmartHouse
{
    internal class PropertyMenu
    {
        public static void SelectionId()
        {
            Home.GetList();

            Console.WriteLine("\nChoice objects ID, to change property.\nPress M to go to Main Menu .");
            Console.Write("\n:  ");
            
            int id = 0;
            string input = Console.ReadLine();
            
            if (Int32.TryParse(input, out id))
            {
                if (id >= Home.equipments.Count && Home.equipments[id] == null)
                {
                    Console.WriteLine("Incorrect input \nPress any key to continue");
                    Console.ReadLine();
                    MainMenu.ChoiceMenu();
                }
                else
                {
                    PropertySelection(id);
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
            while (choice != 9)
            {
                Console.Clear();
                Console.WriteLine("Property list.");
                Console.WriteLine("1. Turn on or turn off.");
                Console.WriteLine("2. Change name.");
                
                if (Home.equipments[id].GetType() == typeof(Lamp))
                {
                    Console.WriteLine("3. Change brightness.");
                }

                Console.WriteLine("9. Back to previus menu.");
                Console.Write("\n:  ");

                string input = Console.ReadLine();

                if (Int32.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Home.SetState(id);
                            break;
                        case 2:
                            Home.SetName(id);
                            break;
                        case 3:
                            if (Home.equipments[id].GetType() == typeof(Lamp))
                            {
                                EquipmentMenu.SetLampBrightness(id);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input \nPlease try again");
                                Console.Write("\n:  ");
                            }
                            break;
                        case 9:
                            SelectionId();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input \nPlease try again");
                    Console.Write("\n:  ");
                }
            }
        }
    }
}
