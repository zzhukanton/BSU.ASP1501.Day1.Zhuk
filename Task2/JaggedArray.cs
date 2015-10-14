using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Class for sorting jagged arrays in different ways
    /// </summary>
    public static class JaggedArray
    {
        /// <summary>
        /// For select sort conditions
        /// </summary>
        /// <param name="array">One string of jagged array</param>
        /// <returns>Sum of elements, max element or min element</returns>
        private delegate int SortingCondition(int[] array);

        /// <summary>
        /// Sorting method for jagged array
        /// </summary>
        /// <param name="array">Sorted array</param>
        /// <param name="sorting">Way of sorting</param>
        /// <param name="order">Order of result array</param>
        public static void SortArrayStrings(int[][] array, SortingWay sorting, Order order)
        {
            SortingCondition condition = null;

            switch (sorting)
            {
                case SortingWay.Sum:
                    condition = Sum;
                    break;
                case SortingWay.Max:
                    condition = MaxElement;
                    break;
                case SortingWay.Min:
                    condition = MinElement;
                    break;
            }

            if (condition != null)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (condition(array[i]) > condition(array[i + 1]))
                        {
                            var temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }

                if (order == Order.Descending)
                    Invert(array);
            }
            else
                throw new Exception("Method of conversion is not defined");
        }

        /// <summary>
        /// Finds sum of all array elements 
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Sum of elements</returns>
        private static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }

        /// <summary>
        /// Finds maximum element in the array
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Maximum element</returns>
        private static int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
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

        /// <summary>
        /// Inverts array
        /// </summary>
        /// <param name="array">Inverted array</param>
        private static void Invert(int[][] array)
        {
            int j = array.Length - 1;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int[] buf = array[i];
                array[i] = array[j];
                array[j] = buf;
                j--;
            }
        }
    }
}
