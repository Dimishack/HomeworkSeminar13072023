using System;

namespace HomeworkSeminar13072023
{
    internal class Program
    {
        static void Main()
        {
			try
			{

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				Console.WriteLine("Нажмите любую клавишу для выхода из программы...");
				Console.ReadKey(true);
			}
        }
    }
}