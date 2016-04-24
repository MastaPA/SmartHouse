using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    internal static class EquipmentMenu
    {
        public static void CreateRadio()
        {
            int id = BaseEquipment.Counter;
            Home.equipments.Add(new Radio() { Id = id });
            Home.SetName(id);

            Console.WriteLine("Radio successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }

        public static void CreateConditioner()
        {
            int id = BaseEquipment.Counter;
            Home.equipments.Add(new Conditioner() { Id = id });
            Home.SetName(id);

            Console.WriteLine("Conditioner successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }

        public static void CreateBoiler()
        {
            int id = BaseEquipment.Counter;
            Home.equipments.Add(new Boiler() { Id = id });
            Home.SetName(id);

            Console.WriteLine("Boiler successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}
