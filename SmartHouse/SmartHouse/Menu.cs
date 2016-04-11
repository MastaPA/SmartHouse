using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Menu
    {
        private string name;
        private bool state;
        private int bright;

        Menu (string name, bool state, int bright)
        {
            this.name = name;
            this.state = state;
            this.bright = bright;
        }
        
        public void SetName()
        {
            string a; 
           do
            {
                Console.Write("Введите название - ");
                a = Console.ReadLine();
            } while (String.IsNullOrEmpty(a));

           name = a;
        }

        public void SetState(int s)
        {
            if (s == 0)
            {
                state = false;
            }
            else
            {
                state = true;
            }
        }

        public void SetBright(int level)
       {
           if (level <= 100 && level >= 0)
           {
               bright = level;
           }
           else
           {
               bright = 0;
               state = false;
           }
       }

        public void Status()
        {
           Console.Write("ID = " + Lamp.Counter + " | ");
           Console.Write("Имя объекта - " + name + " | " + "Состояние - " + (state ? "Вкл" : "Выкл") + " | ");
           Console.WriteLine("Яркость на " + bright + "%");
        }
    }
}
