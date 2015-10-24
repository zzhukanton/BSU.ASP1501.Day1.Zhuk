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
        /// Sorts jagged array with default comparator
        /// </summary>
        /// <param name="array">Jagged array</param>
        public static void SortArrayStrings(int[][] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            else
                SortArrayStrings(array, Comparer<int[]>.Default);
        }

        /// <summary>
        /// Sorts jagged array with condition in IComparer object
        /// </summary>
        /// <param name="array">Jagged array</param>
        /// <param name="comparer">Object that implements IComparer</param>
        public static void SortArrayStrings(int[][] array, IComparer<int[]> comparer)
        {
            if (comparer == null)
                throw new ArgumentNullException("Comparer is null");

            if (!(comparer is IComparer<int[]>))
                throw new ArgumentException("Object don't realize IComparer");
            else
                BubbleSort(array, comparer);
        }

        /// <summary>
        /// Sorts jagged array with bubble sort depending on comparer
        /// </summary>
        /// <param name="array">Jagged array</param>
        /// <param name="comparer">IComparer object with comparing condition</param>
        private static void BubbleSort(int[][] array, IComparer<int[]> comparer)
        {
            int stringsCount = array.Length;

            while (stringsCount - 1 > 0)
            {
                for (int i = 0; i < array.Count() - 1; i++)
                    if (comparer.Compare(array[i], array[i + 1]) > 0)
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                stringsCount--;
            }
        }
    }
}
