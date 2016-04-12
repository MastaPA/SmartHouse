using System;

namespace SmartHouse
{
    internal class LampMenu
    {
        static public string name;
        static private bool state;
        static private int bright;
        private int ID;
        
        static public void SetName(Lamp obj)
        {
            Console.Write("Введите название - ");
            string name = null;
            name = Console.ReadLine();
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Вы не ввели название!\nПопробуйте снова");
                name = Console.ReadLine();
            }
            

        }

        static public void SetState(int s)
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

        static public void SetBright(int level)
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

        static public void Status(Lamp obj)
        {
            Console.Write("ID = {0} |", obj.ID);
            Console.Write("Имя объекта - {0} | Состояние - {1}  | ", obj.Name, (obj.State ? "Вкл" : "Выкл"));
            Console.WriteLine("Яркость на {0}%", obj.Brightness);
        }
        
        public LampMenu(Lamp obj)
        {
            name = obj.Name;
            state = obj.State;
            bright = obj.Brightness;
            ID = obj.ID;
        }
    }
}
