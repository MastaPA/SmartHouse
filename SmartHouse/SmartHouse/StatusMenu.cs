using System;

namespace SmartHouse
{
    internal static class StatusMenu
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

            foreach (BaseEquipment obj in List.objects)
            {
                Console.WriteLine(obj.Id)
            }
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}
