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
            //Console.WriteLine("3. Modify objecst.");
            //Console.WriteLine("4. Remove objects.");
            //Console.WriteLine("5. Quit programm.");
            Console.Write("\n:");

            int choice = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        LampMenu.CreateLamp();
                        break;
                    case 2:
                        EquipmentMenu.CreateRadio();
                        break;
                    //case 3:
                    //    PropertyMenu.SelectionId();
                    //    break;
                    //case 4:
                    //    DeleteMenu.SelectionId();
                    //    break;
                    //case 5:

                    //    break;
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