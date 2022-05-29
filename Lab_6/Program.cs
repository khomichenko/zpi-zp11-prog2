using System;

namespace Lab_6
{
    internal class Program
    {
        /**
         * Базовий клас "Фігури": віртуальні функції обчислення площі і периметра.
         * Похідний клас "Квадрати":
         *      координати вершин,
         *      конструктор з параметрами,
         *      віртуальні функції обчислення площі і периметра.
         * Похідний клас "Коло":
         *      радіус,
         *      конструктор з параметром,
         *      віртуальні функції обчислення площі і периметра
         *
         * Описати класи, об’єкти цих класів;
         * обчислити і вивести площу та периметр об’єктів, використовуючи поліморфізм (вказівну/посилання базового класу)
         */
        public static void Main(string[] args)
        {
            IShape shape01 = new Square(4,5);
            IShape shape02 = new Circle(3);
            Console.WriteLine(shape01.CalcArea());
            Console.WriteLine(shape01.CalcPerimeter());
            Console.WriteLine(shape02.CalcArea());
            Console.WriteLine(shape02.CalcPerimeter());
        }
    }
}