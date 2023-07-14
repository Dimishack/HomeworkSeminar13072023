using HomeworkSeminar13072023.Tasks;
using System;

namespace HomeworkSeminar13072023
{
    internal class Program
    {
        /*
		* Начиная с 8 урока, будет дополнительно учитываться чистота программного кода 
		* ("правильные" имена объектов (методов, массивов, переменных))
		* Все задачки нужно обернуть в методы. 
		* Стили для методов: PascalCase; для переменных/массивов - camelCase
		*/
        static void Main()
        {

            try
            {
                Console.WriteLine("Задача №47");
                Task47.TwoDimensionalArray();
                WaitUser();
                Console.WriteLine("Задача №50");
                Task50.GetValue();
                WaitUser();
                Console.WriteLine("Задача №52");
                Task52.AverageOfColumn();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("\nНажмите любую клавишу для выхода из программы...");
                Console.ReadKey(true);
            }
        }
        private static void WaitUser()
        {
            Console.WriteLine("\nНажмите любую клавишу для перехода к следующей задаче...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}