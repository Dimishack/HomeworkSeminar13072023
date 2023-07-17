using System;

namespace HomeworkSeminar13072023.Tasks
{
    /*
     * Задача 52. Задайте двумерный массив из целых чисел. 
     * Найдите среднее арифметическое элементов в каждом столбце.
     * Например, задан массив:
     * 1 4 7 2
     * 5 9 2 3
     * 8 4 2 4
     * Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    */
    internal class Task52
    {
        internal static void AverageOfColumn()
        {
            var random = new Random();
            var array = new int[random.Next(3, 7), random.Next(3, 7)];

            Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\n" + 
                                new string('-', 30));
            Console.WriteLine("Массив целых чисел (от 0 до 20)");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 20);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(1); i++)
            {
                var sum = 0;
                Console.WriteLine("Среднее арифметическое значение столбца " + i);
                Console.Write('(');
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];
                    Console.Write(array[j, i]);
                    if (j < array.GetLength(0) - 1) Console.Write(" + ");
                }
                var average = Math.Round((double)sum / (double)array.GetLength(0), 2);
                Console.WriteLine(") / {0} = {1}", array.GetLength(0), average);
            }
        }
    }
}
