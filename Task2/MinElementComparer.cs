using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Class for compare strings depending on minimum element in each string
    /// </summary>
    public class MinElementComparer: IComparer<int[]>
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
            int resX = MinElement(x);
            int resY = MinElement(y);

            if (resX == resY)
                return 0;

            if (resX > resY)
                return 1;
            else
                return -1;
        }

        /// <summary>
        /// Finds minimum element in the array
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Minimum element</returns>
        private static int MinElement(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
    }
}
