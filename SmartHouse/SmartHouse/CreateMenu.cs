using System;

namespace SmartHouse
{
    internal class CreateMenu
    {
        static public void CreateLamp ()
        {
            Lamp.lamp[BaseEquipment.Counter] = new Lamp();
            Console.Clear();
            Console.Write("Введите название - ");
            string name;
            name = Console.ReadLine();
            LampMenu.SetName(name);
            Console.WriteLine("Объект успешно создан\nНажмите Enter для продолжения");
            Console.ReadKey();
            MainMenu.ChoiceMenu();
        }
    }
}