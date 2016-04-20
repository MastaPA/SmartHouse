using System;

namespace SmartHouse
{
    public class DeleteMenu
    {
        public static void IdSelection()
        {
            Console.Clear();
            Console.WriteLine("Objects list.");

            for (int i = 0; i < LampMenu.lamps.Length; i++)
            {
                if (LampMenu.lamps[i] != null)
                {
                    LampMenu.Status(LampMenu.lamps[i]);
                }
                else { continue; }
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
                    IdSelection();
                    break;
                case 'n':
                case 'N':
                    MainMenu.ChoiceMenu();
                    break;
            }
        }
    }
}
