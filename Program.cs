using System;
using System.Collections.Generic;

namespace csharp_stack_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};
            Stack<string> s = new Stack<string>();
            int index;
            string result = "";
            Console.Write("Decimal to Binary: ");
            int dec = int.Parse(Console.ReadLine());

            while (dec > 0)
            {
                index = dec % 2;
                s.Push(arr[index]);
                dec = dec / 2;
            }
            while (s.Count > 0)
            {
                result = result + s.Pop();
            }
            Console.WriteLine($"Binary is: {result}");
        }
    }
}
