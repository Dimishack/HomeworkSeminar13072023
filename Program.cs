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
                ConsoleKey key;
                Console.WriteLine("Добро пожаловать в программу с выполненными задачами №47, 50 и 52");
                do
                {
                    Console.WriteLine("Выберите номер из списка с задачами, к которому Вы хотите перейти " +
                        "\n(для выхода из программы нажмите <Enter>)");
                    Console.WriteLine("1) Задача №47 \n2) Задача №50 \n3) Задача №52");
                    key = Console.ReadKey(false).Key;
                    Console.WriteLine();
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            break;
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            Task47.TwoDimensionalArray();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            Task50.GetValue();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            Task52.AverageOfColumn();
                            WaitUser();
                            break;
                        default:
                            Console.WriteLine("Ошибка: Данного номера с задачей нет! Выберите другой.");
                            break;
                    }
                } while (key != ConsoleKey.Enter);                
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
            Console.WriteLine("\nНажмите любую клавишу для перехода обратно в меню...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}