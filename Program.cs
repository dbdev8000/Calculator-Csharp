using System;

namespace Calculator 
{
    class Program 
    {
        static void Main(string[] args) 
        {

            Selection();

        }

        static void Selection() 
        {
            Console.Clear();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Choose the option: ");

        if (!short.TryParse(Console.ReadLine(), out short result))
    {
        Console.WriteLine("\nInvalid input! Please enter a valid option.");
        Console.ReadKey();
        Selection();
        return;
    }
            
            switch(result)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: 
                    Console.WriteLine("\n Invalid option! Try again");
                    Console.ReadKey();
                    Selection();
                    break;

            }
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"\nThe result of sum is {result}");
            Console.WriteLine("\n-------------------------------");
            // Console.WriteLine($"The result of sum is: " + result);
            // Console.WriteLine($"The result of sum is: {v1 + v2}");
            // Console.WriteLine($"The result of sum is: " + (v1 + v2));
           
           Console.ReadKey();
           Selection();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"\nThe result of subtraction is {result}");
            Console.WriteLine("\n-------------------------------");

            Console.ReadKey();
            Selection();
        }

        static void Division()
        {
    Console.Clear();

    Console.WriteLine("First value:");
    if (!float.TryParse(Console.ReadLine(), out float v1))
    {
        Console.WriteLine("\nInvalid input! Try again.");
        Console.ReadKey();
        Division();
        return;
    }

    Console.WriteLine("Second value:");
    if (!float.TryParse(Console.ReadLine(), out float v2) || v2 == 0)
    {
        Console.WriteLine("\nInvalid input! Cannot divide by zero.");
        Console.ReadKey();
        Division();
        return;
    }

    float result = v1 / v2;
    Console.WriteLine("\n-------------------------------");
    Console.WriteLine($"\nThe result of division is {result}");
    Console.WriteLine("\n-------------------------------");

    Console.ReadKey();
    Selection();
        }
    
        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"\nThe result of multiplication is {result}");
            Console.WriteLine("\n-------------------------------");
            Console.ReadKey();
            Selection();
        }
    }
}
