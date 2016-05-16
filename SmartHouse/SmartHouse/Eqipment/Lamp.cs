using System;

namespace SmartHouse.Eqipment
{
    internal class Lamp : BaseEquipment
    {
        public int Brightness { get; set; }

        public override void Status()
        {
            Console.WriteLine("ID: {0} | Name: Lamp {1} | State: {2} | Brightness: {3}%",Id, Name, State ? "On" : "Off", Brightness);
        }

        public void SetBrightness()
        {
            Console.Clear();
            Console.WriteLine("Set brightness from 1 to 100");
            Console.WriteLine("  *Note. Whith brightness more then 100 lamp will burn and turn off.");
            Console.Write("\n:  ");
            int level = Int32.Parse(Console.ReadLine());

            if (level <= 100 && level > 0)
            {
                Brightness = level;
                State = true;
            }
            else
            {
                Brightness = 0;
                State = false;
            }
        }
    }
}
