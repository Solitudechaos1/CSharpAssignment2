using System;

namespace CSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== C# Assignment Menu ===");
                Console.WriteLine("1. Print Hello and Your Name");
                Console.WriteLine("2. Sum of Two Numbers");
                Console.WriteLine("3. Divide Two Numbers");
                Console.WriteLine("4. Specified Operations");
                Console.WriteLine("5. Swap Two Numbers");
                Console.WriteLine("6. Multiply Three Numbers");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine()!;

                Console.Clear();
                switch (choice)
                {
                    case "1": HelloTask.Run(); break;
                    case "2": SumTask.Run(); break;
                    case "3": DivideTask.Run(); break;
                    case "4": OperationsTask.Run(); break;
                    case "5": SwapTask.Run(); break;
                    case "6": MultiplyTask.Run(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
