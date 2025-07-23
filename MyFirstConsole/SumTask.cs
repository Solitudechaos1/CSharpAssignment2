//wap to print sum of two num//
using System;

namespace CSharpAssignment
{
    internal static class SumTask
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Sum = {a + b}");
        }
    }
}
