using System;

namespace SmartHouse
{
    internal class MainMenu
    {
        static public void ChoiceMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Создать объект.");
            Console.WriteLine("2. Просмотр объектов.");
            Console.WriteLine("3. Изменение объектов.");
            Console.WriteLine("4. Удаление объектов.");
            Console.WriteLine("5. Выход из программы.");
            Console.Write("\n:");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LampMenu.CreateLamp();
                    break;
                case 2:
                    StatusMenu.ViewObjects();
                    break;
                case 3:
                    PropertyMenu.IdSelection();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }   
    }
}
