using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseEquipment eqip = new BaseEquipment();
            eqip.SetName();
            eqip.SetState(1);
            eqip.Status();

            Console.ReadKey();
        }
    }
}
