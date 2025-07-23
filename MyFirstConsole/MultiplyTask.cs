//wap to print the output of the multiplication of three number entered by the user//
using System;

namespace CSharpAssignment
{
    internal static class MultiplyTask
    {
        public static void Run()
        {
            Console.Write("Enter number 1: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("Enter number 2: ");
            int y = int.Parse(Console.ReadLine()!);
            Console.Write("Enter number 3: ");
            int z = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Product = {x * y * z}");
        }
    }
}
