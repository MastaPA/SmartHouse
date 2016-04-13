using System;

namespace SmartHouse
{
    internal class StatusMenu
    {
        static public void ViewObjects()
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
            Console.WriteLine("\nНажмите Enter для продолжения");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}
