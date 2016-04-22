using System;

namespace SmartHouse
{
    internal abstract class BaseEquipment
    {
        private static int counter;

        public static int Counter
        {
            get { return counter; }
        }

        public bool State { get; set; }
        
        public string Name { get; set; }

        public int Id { get; set; }

        public BaseEquipment()
        {
            State = false;
            counter += 1;
        }

        public abstract void Status();
    }
}
