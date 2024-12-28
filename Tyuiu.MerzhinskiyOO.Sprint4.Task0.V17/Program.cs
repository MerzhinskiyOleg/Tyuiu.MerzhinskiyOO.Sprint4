using Tyuiu.MerzhinskiyOO.Sprint4.Task0.V17.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Console.WriteLine("Заданный массив: " + "[{0}]", string.Join(",", numArray));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма чётных элементов массива - " );
            Console.ReadKey();
        }
    }
}
