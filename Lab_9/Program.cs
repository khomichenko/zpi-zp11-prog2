using System;
using System.Threading;

namespace Lab_9
{
    internal class Program
    {
        /* Варіант 11
         * Функція (С++) / Метод -статична та екземплярна версії (С#)
         *      Визначення кількості малих символів у рядку
         * Клас (функціональність):
         *      Перевищення максимально допустимої швидкості: Машина: початок руху, рух, кінець руху, заправлення паливом, витрата палива тощо
         * Подія:
         *      Перевищення максимально допустимої швидкості 
         */
        public static void Main(string[] args)
        {
            var delegating = new Delegating();
            Delegating.CountSmall count = delegating.DoCountSmall;
            Console.WriteLine(count("Привіт, Україна")); // Визначення кількості малих символів у рядку

            var car = new Car { MaxSpeed = 60, FuelСonsumption=14 }
                .Refueling(98)
                .Start()
                .Stop();
            Thread.Sleep(6*1000);
        }
    }
}