using System;

namespace SmartHouse
{
    internal class BaseEquipment
    {
        private static int counter;

        public static int Counter
        {
            get { return counter; }
        }

        public bool State { get; set; }
        
        public string Name { get; set; }

        public BaseEquipment()
        {
            State = false;
            counter += 1;
        }
    }
}
