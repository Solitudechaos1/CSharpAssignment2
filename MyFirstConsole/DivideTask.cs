//wap to print the result of two dividng num//
using System;

namespace CSharpAssignment
{
    internal static class DivideTask
    {
        public static void Run()
        {
            Console.Write("Enter numerator: ");
            double num = double.Parse(Console.ReadLine()!);
            Console.Write("Enter denominator: ");
            double den = double.Parse(Console.ReadLine()!);

            if (den == 0)
                Console.WriteLine("Error: Cannot divide by zero!");
            else
                Console.WriteLine($"{num} / {den} = {num / den}");
        }
    }
}
