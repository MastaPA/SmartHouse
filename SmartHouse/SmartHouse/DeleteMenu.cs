using System;

namespace SmartHouse
{
    public class DeleteMenu
    {
        public static void SelectionId()
        {
            Console.Clear();
            Console.WriteLine("Objects list.");

            StatusMenu.ViewObjects();

            Console.WriteLine("\nChoice objects ID, to delete, \nor press M to go to Main Menu .");
            Console.Write("\n:");
            
            int id = 0;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out id))
            {
                if (Home.equipments[id] != null)
                {
                    ConfirmDelete(id);
                }
                else
                {
                    Console.WriteLine("Incorect object ID!");
                    MainMenu.ChoiceMenu();
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
                    Home.Delete(id);
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
