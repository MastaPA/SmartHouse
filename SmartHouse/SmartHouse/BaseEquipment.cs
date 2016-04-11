using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class BaseEquipment
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
