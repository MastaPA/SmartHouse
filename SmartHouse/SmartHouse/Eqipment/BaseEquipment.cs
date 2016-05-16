using System;

namespace SmartHouse.Eqipment
{
    public class BaseEquipment : IBaseEquipment
    {
        public bool State { get; set; }
        
        public string Name { get; set; }

        public int Id { get; set; }

        public BaseEquipment()
        {
            State = false;
        }

        public virtual void Status()
        {
            Console.WriteLine("ID:  " + Id);
        }
    }
}
