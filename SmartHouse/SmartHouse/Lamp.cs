using System;

namespace SmartHouse
{
    internal class Lamp : BaseEquipment
    {
        public int Brightness { get; set; }

        public override void Status()
        {
            Console.WriteLine("ID: {0} | Name: Lamp {1} | State: {2} | Brightness: {3}%",Id, Name, State ? "On" : "Off", Brightness);
        }
    }
}
