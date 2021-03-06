﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHouse.Eqipment;

namespace SmartHouse
{
    internal static class Home
    {
        public static List<BaseEquipment> equipments = new List<BaseEquipment>();

        private static int index = 0;
        
        public static void AddToList(BaseEquipment equip)
        {
            equip.Id = index;
            equipments.Add(equip);
            SetName(index);
            index++;
        }
        
        public static void GetList()
        {
            Console.Clear();
            Console.WriteLine("Objects list.");
            //Console.WriteLine("Amount of objects is - {0}", equipments.Count);

            foreach (BaseEquipment equipment in equipments)
            {
                if (equipment != null)
                {
                    equipment.Status();
                }
            }
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

            equipments[id].Name = name;
        }

        public static void SetState(int id)
        {
            Console.Clear();
            Console.WriteLine("Press 1 to turn on or 0 to turn off");
            Console.Write("\n:  ");
            
            int state = 0;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out state))
            {
                if (state == 0)
                {
                    equipments[id].State = false;
                }
                else if(state == 1)
                {
                    equipments[id].State = true;
                    if (equipments[id].GetType() == typeof(Lamp))
                    {
                        ((Lamp)equipments[id]).Brightness = 100;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value! \nTurning off");
                }
            }
        }

        public static bool CheckId(int id)
        {
            bool check = false;
            
            try
            {
                if (equipments[id] != null)
                {
                check = true;
                }
            }
            catch
            {
                Console.WriteLine("Incorrect ID.");
                check = false;
                return check;
            }
            return check;
        }
        
        public static void Delete(int id)
        {
            equipments[id] = null;
            //equipments.RemoveAt(id);
        }
    }
}
