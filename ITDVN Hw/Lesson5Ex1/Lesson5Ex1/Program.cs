using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomArray array = new RandomArray(213);
        }
    }

    class RandomArray
    {
        private Random rand = new Random();
        public int Length {  get; private set; }
        public int[] Array { get; private set; }
        public RandomArray(int lenght)
        {
            Length = lenght;
            Array = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                Array[i] = rand.Next(10000);
            }
            long sum = 0;
            foreach (int i in Array)
            {
                sum += i;
            }
            Console.WriteLine($"Максимальное значение: {Array.Max()}\nМинимальное значение: {Array.Min()}\n" +
                $"Сумма всех элементов: {sum}\nСреднее арифметическое: {sum / Length}\n" +
                $"Все нечетные значения");
            foreach (int i in Array)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
