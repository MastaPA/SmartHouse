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
            Lamp eqip = new Lamp();
            eqip.SetName();
            eqip.SetState(1);
            eqip.Status();

            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
