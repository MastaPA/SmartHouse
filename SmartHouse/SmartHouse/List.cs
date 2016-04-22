using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    internal static class Home
    {
        public static List<BaseEquipment> equipments = new List<BaseEquipment>();

        public static void GetList(int id)
        {
            equipments[id].Status();
        }

        public static void SetName(int id)
        {
            Console.Clear();
            Console.Write("Enter the name - ");
            string name = Console.ReadLine();

            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("You do not enter the title!\nTry again");
                name = Console.ReadLine();
            }

            Home.equipments[id].Name = name;
        }

        public static void Delete(int id)
        {
            equipments[id] = null;
        }
    }
}
