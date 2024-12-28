using Tyuiu.MerzhinskiyOO.Sprint4.Task2.V23.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов в массиве:");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = rnd.Next(3, 9);
            }
            Console.WriteLine("Получившийся массив:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма чётных элементов массива: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
