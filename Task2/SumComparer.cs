using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Class for compare strings depending on sum of elements
    /// </summary>
    public class SumComparer: IComparer<int[]>
    {
        /// <summary>
        /// IComparer method to compare int[] types in our way
        /// </summary>
        /// <param name="x">First array</param>
        /// <param name="y">Second array</param>
        /// <returns>1, if first more than second, 0 if equal, -1 if second more than first</returns>
        public int Compare(int[] x, int[] y)
        {
            if (x == null || y == null)
                throw new NullReferenceException();
            int resX = Sum(x);
            int resY = Sum(y);

            if (resX == resY)
                return 0;

            if (resX > resY)
                return 1;
            else
                return -1;
        }

        /// <summary>
        /// Finds sum of elements of integer array
        /// </summary>
        /// <param name="array">Array for finding sum</param>
        /// <returns>Sum of elements</returns>
        private static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }
    }
}
