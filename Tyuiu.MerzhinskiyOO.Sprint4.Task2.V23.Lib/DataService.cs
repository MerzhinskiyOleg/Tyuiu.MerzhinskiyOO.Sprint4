using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task2.V23.Lib
{
    public class DataService : ISprint4Task2V23
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    res += number;
                }
            }
            return res;
        }
    }
}
