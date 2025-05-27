using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_4_РКИС
{
    public class Сounting
    {
        public int[,] GenArr(int rows, int cols, int min, int max)
        {
            ValidateParameters(rows, cols, min, max);
            Random rnd = new Random();
            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = rnd.Next(min, max + 1);
                }
            }
            return arr;
        }
        public int NegElCount(int[,] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));
            int count = 0;
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = arr[i, j];
                    if (IsEvenNegative(value))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private bool IsEvenNegative(int number)
        {
            return number < 0 && number % 2 == 0;
        }
        private void ValidateParameters(int rows, int cols, int minValue, int maxValue)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Количество строк и столбцов должно быть больше 0");

            if (minValue > maxValue)
                throw new ArgumentException("Минимальное значение не может быть больше максимального");
        }
    }
}
