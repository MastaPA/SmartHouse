using System;

namespace SmartHouse
{
    internal class Lamp : BaseEquipment
    {
        public int Brightness { get; set; }

        public int ID { get; set; }

        public Lamp ( int id)
        {
            ID = id;
        }
    }
}
