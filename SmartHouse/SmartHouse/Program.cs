using System;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the SmartHouse!");
            Console.WriteLine("1. Settings.");
            Console.WriteLine("2. Exit.");
            Console.Write("\n:  ");

            int choice = 0;

            while (choice != 2)
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MainMenu.ChoiceMenu();
                            break;
                        case 2:
                            Console.WriteLine("Press any key to exit");
                            break;
                        default:
                            Console.WriteLine("You enter invalid value\nTry again");
                            break;
                    }
                }
             }

            Console.ReadKey();
        }
    }
}
