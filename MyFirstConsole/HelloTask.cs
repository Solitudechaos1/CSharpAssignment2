//wap to print hello and your name in a separate line//
using System;

namespace CSharpAssignment
{
    internal static class HelloTask
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Hello");
            Console.WriteLine(name);
        }
    }
}
