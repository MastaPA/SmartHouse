using System;

namespace SmartHouse
{
    internal static class LampMenu
    {
        public static Lamp[] lamp = new Lamp[10];

        public static void CreateLamp()
        {
            int id = BaseEquipment.Counter;
            lamp[id] = new Lamp();
            SetName(lamp[id]);
            Console.WriteLine("lampect successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }

        public static void SetName(Lamp lamp)
        {
            Console.Clear();
            Console.Write("Enter the title - ");
            string name;
            name = Console.ReadLine();
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
            Console.Write("ID = {0} |", lamp.ID);
            Console.Write("Name - {0} | State - {1}  | ", lamp.Name, (lamp.State ? "On" : "Off"));
            Console.WriteLine("Brightness {0}%", lamp.Brightness);
        }
    }
}
