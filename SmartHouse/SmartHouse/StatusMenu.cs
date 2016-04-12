using System;

namespace SmartHouse
{
    internal class StatusMenu
    {
        static public void ViewObjects()
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)       // 10 need to be changed to "lamp.arraySize"
            {
                if (Lamp.lamp[i] != null)
                {
                    Console.Write("ID = {0} |", Lamp.lamp[i].ID);
                    Console.Write("Имя объекта - {0} | Состояние - {1}  | ", Lamp.lamp[i].Name, (Lamp.lamp[i].State ? "Вкл" : "Выкл"));
                    Console.WriteLine("Яркость на {0}%", Lamp.lamp[i].Brightness);
                    Console.WriteLine("Нажмите Enter для продолжения");
                }
                else { continue; }
                //MainMenu.ChoiceMenu();
            }
            Console.ReadKey();
        }
    }
}
