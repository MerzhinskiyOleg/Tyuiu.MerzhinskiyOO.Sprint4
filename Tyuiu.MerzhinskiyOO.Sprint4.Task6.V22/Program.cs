using Tyuiu.MerzhinskiyOO.Sprint4.Task6.V22.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task6.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var word = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= word.Length - 1; i++)
            {
                Console.WriteLine(word[i]);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Количество элементов длинна которых = 7:");


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
