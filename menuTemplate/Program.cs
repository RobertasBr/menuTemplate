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
            Console.WriteLine("MENU: Select items 1-3");

            string choice = Console.ReadLine();
            int.TryParse(choice, out int choices);

            switch (choices)
            {
                case 1:
                    Console.WriteLine("Item one");
                    //Method one goes here
                    break;
                case 2:
                    Console.WriteLine("Item two");
                    //Method two goes here
                    break;
                case 3:
                    Console.WriteLine("Item three");
                    //Method three goes here, can keep adding cases if needed
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again!");
                    //Error message
                    break;
            }
        }
    }
}
