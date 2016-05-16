using System;

namespace SmartHouse.Eqipment
{
    class Conditioner : BaseEquipment
    {
        public override void Status()
        {
            Console.WriteLine("ID: {0} | Name: Conditioner {1} | State: {2}", Id, Name, State ? "On" : "Off");
        }
    }
}
