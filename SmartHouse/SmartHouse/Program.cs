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
            Console.WriteLine("Вас приветствует Ваш туповатый дом!");
            Console.WriteLine("1. Создать объект.");
            Console.WriteLine("2. Просмотр объектов.");
            Console.WriteLine("3. Изменение объектов.");
            Console.WriteLine("4. Удаление объектов.");
            Console.WriteLine("5. Выход из программы.");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Lamp lamp1 = new Lamp();
                    Menu item1 = new Menu(string Name, bool lamp1.State, int lamp1.Brightness);
                    item1.SetName();
                    item1.SetState(1);
                    item1.SetBright(50);
                    break;
                case 2:
                    item1.Status();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;

            }

            

            
            Console.ReadKey();
        }
    }
}
