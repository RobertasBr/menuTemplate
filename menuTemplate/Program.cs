using System;

namespace menuTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            menuChoice();
        }
        static void menuChoice()
        {
            bool userDone = true;

            while (userDone) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Option One");
                Console.WriteLine("2 - Option Two");
                Console.WriteLine("3 - Option Three");
                Console.Write("0 - To Exit: ");


                string choice = Console.ReadLine();
                char.TryParse(choice, out char choices);

                switch (choices)
                {
                    case '0':
                        userDone = false;
                        break;
                    case '1':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Item one\n");
                        //Method one goes here
                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Item two\n");
                        //Method two goes here
                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Item three\n");
                        //Method three goes here, can keep adding cases if needed
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid choice\n");
                        //Error message
                        continue;
                }
            }
            return;
        }
    }
}
