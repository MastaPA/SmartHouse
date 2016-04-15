using System;

namespace SmartHouse
{
    internal class StatusMenu
    {
        public static void ViewObjects()
        {
            Console.Clear();
            for (int i = 0; i < LampMenu.lamp.Length; i++)
            {
                if (LampMenu.lamp[i] != null)
                {
                    LampMenu.Status(LampMenu.lamp[i]);
                }
                else { continue; }
            }
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}
