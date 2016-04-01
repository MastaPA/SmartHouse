using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class BaseEquipment
    {
        private string name;
        private bool state;

        public BaseEquipment()
        {
            SetState(0);
        }

        public void SetState(int a)
        {
            if (a == 0)
                state = false;
            else
                state = true;
        }

        public bool GetState() { return state; }

        public void SetName()
        {
            string s;
            do
            {
                Console.Write("Введите название - ");
                s = Console.ReadLine();
            } while (String.IsNullOrEmpty(s));

            name = s;
        } 

        public void Status ()
        {
            Console.WriteLine("Имя объекта - " + name + "\nСостояние - " + (state ? "Вкл" : "Выкл"));
        }
    }
}
