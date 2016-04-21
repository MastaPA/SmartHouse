using System;

namespace SmartHouse
{
    public class DeleteMenu
    {
        public static void SelectionId()
        {
            Console.Clear();
            Console.WriteLine("Objects list.");

            if (LampMenu.lamps == null || LampMenu.lamps.Length == 0)
            {
                Console.WriteLine("No items to delete.");
            }
            else
            {
                for (int i = 0; i < LampMenu.lamps.Length; i++)
                {
                    Console.WriteLine("Step" + i);
                    if (LampMenu.lamps[i] != null)
                    {
                        LampMenu.Status(LampMenu.lamps[i]);
                    }
                }
            }

            Console.WriteLine("\nChoice objects ID, to delete, \nor press M to go to Main Menu .");
            Console.Write("\n:");
            
            int id = 0;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out id))
            {
                if (LampMenu.lamps[id] == null)
                {
                    Console.WriteLine("Incorect object ID!");
                    MainMenu.ChoiceMenu();
                }
                else
                {
                    ConfirmDelete(id);
                }
            }
            else
            {
                MainMenu.ChoiceMenu();
            }
        }

        public static void ConfirmDelete(int id)
        {
            char answer;

            do
            {
                Console.Clear();
                Console.WriteLine("Are you sure want to delete this object?");
                Console.WriteLine("Press Y for delete or N for back to previus menu.");
                Console.Write("\n:");
                answer = char.Parse(Console.ReadLine());
            }
            while (answer != 'y' && answer != 'Y' && answer != 'n' && answer != 'N');

            switch (answer)
            {
                case 'y':
                case 'Y':
                    LampMenu.Delete(id);
                    SelectionId();
                    break;
                case 'n':
                case 'N':
                    MainMenu.ChoiceMenu();
                    break;
            }
        }
    }
}
