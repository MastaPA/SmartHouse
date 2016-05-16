using System;

namespace SmartHouse.Eqipment
{
    class Boiler : BaseEquipment
    {
        public override void Status()
        {
            Console.WriteLine("ID: {0} | Name: Boiler {1} | State: {2}", Id, Name, State ? "On" : "Off");
        }
    }
}
