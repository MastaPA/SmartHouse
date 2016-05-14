using System;

namespace SmartHouse
{
    class Radio : BaseEquipment
    {
        public override void Status()
        {
            Console.WriteLine("ID: {0} | Name: Radio {1} | State: {2}", Id, Name, State ? "On" : "Off");
        }
    }
}
