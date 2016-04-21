using System;

namespace SmartHouse
{
    internal static class LampMenu
    {
        public static Lamp[] lamps = new Lamp[10];

        public static void CreateLamp()
        {
            int id = BaseEquipment.Counter;
            lamps[id] = new Lamp 
            { 
                Id = id
            };
            SetName(lamps[id]);

            Console.WriteLine("lamp successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }

        public static void SetName(Lamp lamp)
        {
            Console.Clear();
            Console.Write("Enter the title - ");
            string name = Console.ReadLine();

            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("You do not enter the title!\nTry again");
                name = Console.ReadLine();
            }

            lamp.Name = name;
        }

        public static void SetState(Lamp lamp)
        {
            Console.Clear();
            Console.WriteLine("Press 1 to turn on or 0 to turn off");
            Console.Write("\n:");
            int s = Int32.Parse(Console.ReadLine());

            if (s == 0)
            {
                lamp.State = false;
            }
            else
            {
                lamp.State = true;
                lamp.Brightness = 100;
            }
        }

        public static void SetBrightness(Lamp lamp)
        {
            Console.Clear();
            Console.WriteLine("Set brightness from 1 to 100");
            Console.WriteLine("  *Note. Whith brightness more then 100 lamp will burn and turn off.");
            Console.Write("\n:");
            int level = Int32.Parse(Console.ReadLine());

            if (level <= 100 && level > 0)
            {
                lamp.Brightness = level;
            }
            else
            {
                lamp.Brightness = 0;
                lamp.State = false;
            }
        }

        public static void Status(Lamp lamp)
        {
            Console.Write("ID = {0} |", lamp.Id);
            Console.Write("Name - {0} | State - {1}  | ", lamp.Name, (lamp.State ? "On" : "Off"));
            Console.WriteLine("Brightness {0}%", lamp.Brightness);
        }

        public static void Delete (int id)
        {
            for (int i = 0; i <= lamps.Length; i++)
            {
                if (i == id)
                    lamps[i] = null;
            }

        }
    }
}
