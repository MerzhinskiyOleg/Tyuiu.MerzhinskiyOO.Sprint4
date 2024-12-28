using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task0.V17.Lib
{
    public class DataService : ISprint4Task0V17
    {
        int ISprint4Task0V17.GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
