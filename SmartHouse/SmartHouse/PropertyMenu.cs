using System;

namespace SmartHouse
{
    internal class PropertyMenu // Пока что только для лампочек
    {
        public static void IdSelection()
        {
            Console.Clear();
            Console.WriteLine("Objects list.");
            
            for (int i = 0; i < LampMenu.lamps.Length; i++)
            {
                if (LampMenu.lamps[i] != null)
                {
                    LampMenu.Status(LampMenu.lamps[i]);
                }
                else { continue; }
            }

            Console.WriteLine("Choice objects ID, to change property.");
            Console.Write("\n:");
            int id = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out id))
            {
                PropertySelection(id);
            }
            else { Console.WriteLine("Incorrect input"); }
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
                        LampMenu.SetState(LampMenu.lamps[id]);
                        break;
                    case 2:
                        LampMenu.SetName(LampMenu.lamps[id]);
                        break;
                    case 3:
                        LampMenu.SetBrightness(LampMenu.lamps[id]);
                        break;
                    case 4:
                        IdSelection();
                        break;
                }
            }
        }
    }
}
