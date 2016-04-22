using System;

namespace SmartHouse
{
    internal static class StatusMenu
    {
        public static void ViewObjects()
        {
            Console.Clear();
            Console.WriteLine("Objects list.");

            foreach (BaseEquipment obj in Home.equipments)
            {
                if (obj != null)
                {
                    Home.GetList(obj.Id);
                }
            }
        }

        public static void BackMainMenu()
        {
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}
