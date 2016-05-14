using System;

namespace SmartHouse
{
    public abstract class BaseEquipment
    {
        //public static int Counter { get; private set; }

        public bool State { get; set; }
        
        public string Name { get; set; }

        public int Id { get; set; }

        public BaseEquipment()
        {
            State = false;
            //Counter += 1;
        }

        public abstract void Status();
    }
}
