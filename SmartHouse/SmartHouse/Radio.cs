using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Radio : BaseEquipment
    {
        public override void Status()
        {
            Console.WriteLine("ID = {0} | Name - Radio {1} | State - {2}", Id, Name, State ? "On" : "Off");
        }
    }
}
