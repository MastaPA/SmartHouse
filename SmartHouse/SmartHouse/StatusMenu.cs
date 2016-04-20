using System;

namespace SmartHouse
{
    internal class StatusMenu
    {
        public static void ViewObjects()
        {
            Console.Clear();
            for (int i = 0; i < LampMenu.lamps.Length; i++)
            {
                if (LampMenu.lamps[i] != null)
                {
                    LampMenu.Status(LampMenu.lamps[i]);
                }
                else { continue; }
            }
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}
