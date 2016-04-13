using System;

namespace SmartHouse
{
    static internal class LampMenu
    {
        static public Lamp[] lamp = new Lamp[10];

        static public void CreateLamp()
        {
            int id = BaseEquipment.Counter;
            lamp[id] = new Lamp();
            SetName(lamp[id]);
            Console.WriteLine("Объект успешно создан\nНажмите Enter для продолжения");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }

        static public void SetName(Lamp obj)
        {
            Console.Clear();
            Console.Write("Введите название - ");
            string name;
            name = Console.ReadLine();
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Вы не ввели название!\nПопробуйте снова");
                name = Console.ReadLine();
            }
            obj.Name = name;
        }

        static public void SetState(Lamp obj)
        {
            Console.Clear();
            Console.WriteLine("Нажмите 1 для включения или 0 для выключения");
            int s = Int32.Parse(Console.ReadLine());

            if (s == 0)
            {
                obj.State = false;
            }
            else
            {
                obj.State = true;
                obj.Brightness = 100;
            }
        }

        static public void SetBright(Lamp obj)
        {
            Console.Clear();
            Console.WriteLine("Назначьте яркость от 1 до 100");
            Console.WriteLine("  *Примечание. При яркости выше 100 лампочка сгорит и выключится.");
            int level = Int32.Parse(Console.ReadLine());
            if (level <= 100 && level > 0)
            {
                obj.Brightness = level;
            }
            else
            {
                obj.Brightness = 0;
                obj.State = false;
            }
        }

        static public void Status(Lamp obj)
        {
            Console.Write("ID = {0} |", obj.ID);
            Console.Write("Имя объекта - {0} | Состояние - {1}  | ", obj.Name, (obj.State ? "Вкл" : "Выкл"));
            Console.WriteLine("Яркость на {0}%", obj.Brightness);
        }
    }
}
