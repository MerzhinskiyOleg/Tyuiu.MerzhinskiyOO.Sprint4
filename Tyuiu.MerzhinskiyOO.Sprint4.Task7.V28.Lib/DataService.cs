﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MerzhinskiyOO.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int mult = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        mult *= matrix[i, j];
                    }
                }
            }
            return mult;
        }
    }
}
