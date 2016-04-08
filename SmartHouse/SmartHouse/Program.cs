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
            Menu sMenu = new Menu();
            sMenu.Status();

            sMenu.Name = "Lamp1";
            sMenu.State = true;
            sMenu.Brightness = 50;

            sMenu.Status();

            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
