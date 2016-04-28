using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    internal static class EquipmentMenu
    {
        public static void CreateLamp()
        {
            int id = BaseEquipment.Counter;
            Home.equipments.Add(new Lamp() { Id = id });
            Home.SetName(id);

            Console.WriteLine("lamp successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }

        public static void SetLampBrightness(int id)
        {
            Console.Clear();
            Console.WriteLine("Set brightness from 1 to 100");
            Console.WriteLine("  *Note. Whith brightness more then 100 lamp will burn and turn off.");
            Console.Write("\n:  ");
            int level = Int32.Parse(Console.ReadLine());

            if (level <= 100 && level > 0)
            {
                ((Lamp)Home.equipments[id]).Brightness = level;
                Home.equipments[id].State = true;
            }
            else
            {
                ((Lamp)Home.equipments[id]).Brightness = 0;
                Home.equipments[id].State = false;
            }
        }

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
