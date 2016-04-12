using System;

namespace SmartHouse
{
    internal class Lamp : BaseEquipment
    {
        static public Lamp[] lamp = new Lamp[10];

        public int Brightness { get; set; }

        public int ID { get; set; }

        public Lamp ()
        {
            ID = BaseEquipment.Counter;
        }
    }
}
