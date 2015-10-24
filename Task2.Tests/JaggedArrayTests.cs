using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2.Tests
{
    [TestFixture]
    public class JaggedArrayTests
    {
        [TestCase(Result = true)]
        public bool SortArrayStringsTest_SumComparing()
        {
            int[][] inputArray = new int[][] 
            {
                new int[] {1, 0, 8, 0},
                new int[] {-3, 10, 16},
                new int[] {6, 2, 5}
            };
            int[][] outputArray = new int[][] 
            {
                new int[] {1, 0, 8, 0},
                new int[] {6, 2, 5},
                new int[] {-3, 10, 16}
            };

            IComparer<int[]> comparer = new SumComparer();
            JaggedArray.SortArrayStrings(inputArray, comparer);

            return Equals(inputArray, outputArray);
        }

        [TestCase(0, 0, Result = true)]
        public bool SortArrayStringsTest_MaxElementComparing()
        {
            int[][] inputArray = new int[][] 
            {
                new int[] {1, 0, 8, 0},
                new int[] {-3, 10, 16},
                new int[] {6, 2, 5}
            };
            int[][] outputArray = new int[][] 
            {
                new int[] {6, 2, 5},
                new int[] {1, 0, 8, 0},
                new int[] {-3, 10, 16}
            };

            IComparer<int[]> comparer = new MaxElementComparer();
            JaggedArray.SortArrayStrings(inputArray, comparer);

            return Equals(inputArray, outputArray);
        }

        [TestCase(Result = true)]
        public bool SortArrayStringsTest_MinElementComparing()
        {
            int[][] inputArray = new int[][] 
            {
                new int[] {1, 0, 8, 0},
                new int[] {-3, 10, 16},
                new int[] {6, 2, 5}
            };
            int[][] outputArray = new int[][] 
            {
                new int[] {-3, 10, 16},
                new int[] {1, 0, 8, 0},
                new int[] {6, 2, 5}
            };

            IComparer<int[]> comparer = new MinElementComparer();
            JaggedArray.SortArrayStrings(inputArray, comparer);

            return Equals(inputArray, outputArray);
        }

        private static bool Equals(int[][] first, int[][] second)
        {
            bool isEqual = true;
            int i = 0;

            foreach (int[] firstString in first)
            {
                if (!firstString.SequenceEqual(second[i++]))
                    isEqual = false;
            }

            return isEqual;
        }
    }
}