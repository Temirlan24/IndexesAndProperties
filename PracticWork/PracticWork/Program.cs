using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите индексный диапазон (начало): ");
            int.TryParse(Console.ReadLine(), out int lowIndex);
            Console.WriteLine("Введите индексный диапазон (конец): ");
            int.TryParse(Console.ReadLine(), out int highIndex);
            Random random = new Random();
            if (lowIndex < highIndex)
            {
                Console.WriteLine("Нижний индекс = {0}. Вверхний индекс = {1}", lowIndex, highIndex);
                RangeOfArray range = new RangeOfArray(lowIndex, highIndex);
                for (int i = 0; i < range.array.Length; i++)
                {
                    range.array[i] = random.Next(1, 20);
                }
                range.ShowIndexation(range, lowIndex);
            }
            else
            {
                Console.WriteLine("Введены некорректные индексы!!!");
            }
            Console.ReadKey();
        }
    }
}

