using System;

namespace SmartHouse
{
    internal class PropertyMenu // Пока что только для лампочек
    {
        static public void IdSelection()
        {
            Console.Clear();
            Console.WriteLine("Список существующих объектов.");
            
            for (int i = 0; i < LampMenu.lamp.Length; i++)
            {
                if (LampMenu.lamp[i] != null)
                {
                    LampMenu.Status(LampMenu.lamp[i]);
                }
                else { continue; }
            }

            Console.WriteLine("Выберите ID объекта, состояние которого вы хотите изменить.");
            Console.Write("\n:");
            int id = Int32.Parse(Console.ReadLine()) - 1;
            PropertySelection(id);
        }

        static public void PropertySelection(int id)
        {
            int choice = 0;
            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("Выберите что вы хотите сделать с объектом.");
                Console.WriteLine("1. Включить или выключить.");
                Console.WriteLine("2. Изменить имя.");
                Console.WriteLine("3. Изменить яркость.");
                Console.WriteLine("4. Назад.");
                Console.Write("\n:");

                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LampMenu.SetState(LampMenu.lamp[id]);
                        break;
                    case 2:
                        LampMenu.SetName(LampMenu.lamp[id]);
                        break;
                    case 3:
                        LampMenu.SetBright(LampMenu.lamp[id]);
                        break;
                    case 4:
                        IdSelection();
                        break;
                }
            }
        }
    }
}
