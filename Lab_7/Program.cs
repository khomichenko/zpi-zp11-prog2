using System;

namespace Lab_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new Expression { A=1, B=2, C=3  });
            Console.WriteLine(new Expression { A=4, B=7, C=34  });
            Console.WriteLine(new Expression { A=23, B=42, C=1  });
        }
    }
}