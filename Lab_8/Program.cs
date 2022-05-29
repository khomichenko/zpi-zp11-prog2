using System;

namespace Lab_8
{
    internal class Program
    {
        /*
         * Тип даних елементів float
         * Односпрямований
         * Спосіб додавання елементу списку = Включення до початку
         * Знайти кількість елементів, більших за середнє значення. Видалити всі від’ємні елементи.
         */
        public static void Main(string[] args)
        {
            var list = new SingleLinkedList();
            list.AddElement(5.5f);
            list.AddElement(-5.5f);
            list.AddElement(1.3f);
            list.AddElement(7.1f);
            list.AddElement(-10.1f);
            Console.WriteLine($"Кількість елементів, що більші за середнє: {list.GetCountMoreAverage()}");
        }
    }
}