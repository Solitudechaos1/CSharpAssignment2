using System;

namespace CSharpAssignment
{
    internal static class SwapTask
    {
        public static void Run()
        {
            Console.Write("Enter first number (A): ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter second number (B): ");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Before swap: A = {a}, B = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap: A = {a}, B = {b}");
        }
    }
}
