using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Menu
    {
        public void SetName()
        {
            string a; 
           do
            {
                Console.Write("Введите название - ");
                a = Console.ReadLine();
            } while (String.IsNullOrEmpty(a));

           Name = a;
        }

        public void SetState(int level)
       {
           if (level <= 100 && level >= 0)
               Brightness = level;
           else
           {
               Brightness = 0;
               State = false;
           }
       }

        public void Status()
        {
           Console.Write("ID = " + Lamp.Counter + " | ");
           Console.Write("Имя объекта - " + Lamp.Name + " | " + "Состояние - " + (Lamp.State ? "Вкл" : "Выкл") + " | ");
           Console.WriteLine("Яркость на " + Lamp.Brightness + "%");
        }
    }
}
