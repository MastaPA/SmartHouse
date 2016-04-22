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

            Console.WriteLine("lamp successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}
