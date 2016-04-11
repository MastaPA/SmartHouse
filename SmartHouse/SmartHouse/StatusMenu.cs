using System;

namespace SmartHouse
{
    internal class StatusMenu
    {
        static public void ViewObjects()
        {
            Console.Clear();
            for (int i = 0; i <= 10; i++)       // 10 need to be changed to "lamp.arraySize"
            {
                Console.Write("ID = " + BaseEquipment.Counter + " | ");
                Console.Write("Имя объекта - " + Lamp.lamp[i].Name + " | " + "Состояние - " + (Lamp.lamp[i].State ? "Вкл" : "Выкл") + " | ");
                Console.WriteLine("Яркость на " + Lamp.lamp[i].Brightness + "%");
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadKey();
                MainMenu.ChoiceMenu();
            }
        }
    }
}
