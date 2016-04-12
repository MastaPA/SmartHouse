using System;

namespace SmartHouse
{
    internal class StatusMenu
    {
        static public void ViewObjects()
        {
            Console.Clear();
            for (int i = 0; i < Lamp.lamp.Length; i++)
            {
                if (Lamp.lamp[i] != null)
                {
                    LampMenu.Status(Lamp.lamp[i]);
                }
                else { continue; }
                //MainMenu.ChoiceMenu();
            }
            Console.ReadKey();
        }
    }
}
