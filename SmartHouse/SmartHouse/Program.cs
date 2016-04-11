using System;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует Ваш туповатый дом!");
            Console.WriteLine("1. Настройки.");
            Console.WriteLine("2. Выход.");

            int choice = 0;

            while (choice != 2)
            {
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MainMenu.ChoiceMenu();
                        break;
                    case 2:
                        Console.WriteLine("Press any key to exit");
                        break;
                    default:
                        Console.WriteLine("Вы ввели недопустимое значение\nПопробуйте снова");
                        break;
                }
             }

            Console.ReadKey();
        }
    }
}
