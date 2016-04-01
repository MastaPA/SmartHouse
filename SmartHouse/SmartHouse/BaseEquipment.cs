using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class BaseEquipment
    {
        public BaseEquipment()
        {
            setState(0);

        }

        public void setState(int a)
        {
            if (a == 0)
                state = false;
            else
                state = true;
        }

        public bool getState() { return state; }

        public void setName()
        {
            string s;
            do
            {
                Console.WriteLine("Введите название - ");
                s = Console.ReadLine();
            } while (s == null);

            name = s;
        } 

        public void Status ()
        {
            Console.WriteLine("Имя объекта - " + name + "\nСостояние - " + ((state == true) ? "Вкл" : "Выкл"));
        }

        private string name;
        private bool state;
    }
}
