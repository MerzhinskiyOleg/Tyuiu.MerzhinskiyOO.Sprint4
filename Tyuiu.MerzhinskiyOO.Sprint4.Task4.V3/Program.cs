using Tyuiu.MerzhinskiyOO.Sprint4.Task4.V3.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[,] matrix = new int[5, 5] {{ 7, 9, 7, 8, 6 },
                                           { 4, 4, 4, 8, 6 },
                                           { 7, 9, 6, 7, 6 },
                                           { 7, 5, 4, 9, 8 },
                                           { 9, 6, 4, 9, 8 } };

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество столбцов:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк:");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] x = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Введите элемент " + i + j + " : ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{x[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x));
        }
    }
}
