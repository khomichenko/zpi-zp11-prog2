using System;

namespace Lab_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = 65222232;
            var b = a ^ 1; // +1
            Console.Out.Write("Операція інкремента: ");
            Console.Out.Write(Convert.ToString(a, 10));
            Console.Out.Write("=>");
            Console.Out.Write(Convert.ToString(a, 2));
            Console.Out.Write("=>");
            Console.Out.Write(Convert.ToString(b, 2));
            Console.Out.Write("=>");
            Console.Out.WriteLine(Convert.ToString(b, 10));

        }
    }
}