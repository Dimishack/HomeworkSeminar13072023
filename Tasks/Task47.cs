using System;

namespace HomeworkSeminar13072023.Tasks
{
    /*
     * Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
     * m = 3, n = 4.
     * 0,5 7 -2 -0,2
     * 1 -3,3 8 -9,9
     * 8 7,8 -7,1 9
     */
    internal class Task47
    {
        internal static void TwoDimensionalArray()
        {
            uint GetQuantity(string message)
            {
                uint quantity;

                Console.WriteLine("(Примечание: число должно быть положительным)");
                while (true)
                {
                    Console.Write("Введите {0}: ", message);
                    if (uint.TryParse(Console.ReadLine(), out quantity))
                        break;
                    Console.WriteLine("Данное значение не является положительным числом!");
                }
                return quantity;
            }

            Random rnd = new();
            uint row, column;

            Console.WriteLine("Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами." + 
                                "\n" + new string('-', 50));
            row = GetQuantity("m (количество строк)");
            column = GetQuantity("n (количество столбцов)");
            double[,] array = new double[row, column];
            Console.WriteLine("Двумерный массив вещественных чисел:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = Math.Round(rnd.NextDouble() * Math.Exp(rnd.Next(1, 4)), 2);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
