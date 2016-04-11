using System;

namespace SmartHouse
{
    internal class LampMenu
    {
        static public string name;
        private bool state;
        private int bright;

        public LampMenu (Lamp obj)
        {
            name = obj.Name;
            state = obj.State;
            bright = obj.Brightness;
        }
        
        static public void SetName(string a)
        {
           while (String.IsNullOrEmpty(a))
            {
                Console.WriteLine("Вы не ввели название!\nПопробуйте снова");
                a = Console.ReadLine();
            }
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
