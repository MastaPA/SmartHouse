using System;
using System.Collections.Generic;

namespace SmartHouse
{
    internal static class LampMenu
    {
        //public static Lamp[] lamps = new Lamp[10];

        public static void CreateLamp()
        {
            int id = BaseEquipment.Counter;
            List.objects.Add(new Lamp() { Id = id });
            SetName(id);
            
            Console.WriteLine("lamp successfully created\nPress Enter to continue");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }

        public static void SetName(int id)
        {
            Console.Clear();
            Console.Write("Enter the title - ");
            string name = Console.ReadLine();

            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("You do not enter the title!\nTry again");
                name = Console.ReadLine();
            }

            List.objects[id].Name = name;
        }

        public static void SetState(int id)
        {
            Console.Clear();
            Console.WriteLine("Press 1 to turn on or 0 to turn off");
            Console.Write("\n:");
            int s = Int32.Parse(Console.ReadLine());

            if (s == 0)
            {
                List.objects[id].State = false;
            }
            else
            {
                List.objects[id].State = true;
                //List.objects[id].Brightness = 100;
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

        public static void Status(int id)
        {
            Console.Write("ID = {0} |", List.objects[id].Id);
            Console.Write("Name - {0} | State - {1}  | ", List.objects[id].Name, (List.objects[id].State ? "On" : "Off"));
            //Console.WriteLine("Brightness {0}%", lamp.Brightness);
        }

        public static void Delete (int id)
        {
            //for (int i = 0; i <= lamps.Length; i++)
            //{
            //    if (i == id)
            //        lamps[i] = null;
            //}
            List.objects.RemoveAt(id);
        }
    }
}
