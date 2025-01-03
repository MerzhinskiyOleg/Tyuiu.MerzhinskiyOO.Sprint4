﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int multiArray = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    multiArray *= array[i];
                }
            }
            return multiArray;
        }
    }
}
