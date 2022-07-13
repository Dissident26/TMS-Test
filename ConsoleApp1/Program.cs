using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = String.Empty;
            int age = 0;
            int height = 0;

            Console.WriteLine("press any key to continue");

            var response = Console.ReadKey(true).Key;
             
            while (response != ConsoleKey.Escape)
            {
                Console.WriteLine("press 1 to enter name");
                Console.WriteLine("press 2 to enter age");
                Console.WriteLine("press 3 to enter height");
                Console.WriteLine("press 'P' to print result");
                Console.WriteLine("press 'Escape' to exit");

                response = Console.ReadKey(true).Key;

                switch (response)
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine("Enter your name: ");
                            name = Console.ReadLine();

                            break;
                        };
                    case ConsoleKey.D2:
                        {
                            Console.WriteLine("Enter your age: ");
                            string input = Console.ReadLine();
                            bool isValid = int.TryParse(input, out var number);
                            if (!isValid)
                            {
                                Console.WriteLine("Invalid input!");
                            }

                            age = number;
                            break;
                        }
                    case ConsoleKey.P:
                        {
                            Console.WriteLine("******************");
                            Console.WriteLine("Name: {0}", name);
                            Console.WriteLine("Age: {0}", age);
                            Console.WriteLine("Height: {0}", height);
                            Console.WriteLine("******************");

                            break;
                        }
                        case ConsoleKey.D3:
                        {
                            Console.WriteLine("Enter your height: ");
                            string input = Console.ReadLine();
                            bool isValid = int.TryParse(input, out var number);
                            if (!isValid)
                            {
                                Console.WriteLine("Invalid input!");
                            }

                            height = number;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu selection!");

                            break;
                        }  
                }
            }          
        }
    }
}
