using System;

namespace HomeworkSeminar13072023.Tasks
{
    /*
     * Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
     * и возвращает значение этого элемента или же указание, что такого элемента нет.
     * Например, задан массив:
     * 1 4 7 2
     * 5 9 2 3
     * 8 4 2 4
     * 17 -> такого числа в массиве нет
     */
    internal class Task50
    {
        internal static void GetValue()
        {
            Random rnd = new();
            string gettingPosition;
            uint[] position = new uint[2];
            double[,] array = new double[rnd.Next(2, 6), rnd.Next(2, 6)];

            Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве," +
                            " и возвращает значение этого элемента или же указание, что такого элемента нет." +
                            "\n" + new string('-', 30));
            Console.WriteLine("Двумерный массив вещественных чисел");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Math.Round(rnd.NextDouble() * Math.Exp(rnd.Next(1, 4)), 2);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            while (true)
            {
                Console.WriteLine("Введите позицию элемента, который хотите получить (2 цифры)" +
                    "\nПример ввода: 35 или 08" +
                    "\nПервая цифра - строка, вторая - столбец");
                gettingPosition = Console.ReadLine();
                if (gettingPosition.Length == 2)
                    break;
                Console.WriteLine("Позиция введена неккоректно!");
            }
            for (int i = 0; i < gettingPosition.Length; i++)
            {
                uint num;
                if (!Char.IsDigit(gettingPosition[i]) || (num = Convert.ToUInt32(gettingPosition[i] - '0')) >= array.GetLength(i))
                {
                    Console.WriteLine("Числа с позицией {0} в массиве нет", gettingPosition);
                    return;
                }
                position[i] = num;
            }
            Console.WriteLine("Число с позицией {0} в массиве: {1}", gettingPosition, array[position[0], position[1]]);
        }
    }
}
