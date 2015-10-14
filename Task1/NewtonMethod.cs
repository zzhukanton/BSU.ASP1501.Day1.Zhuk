using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Class for finding root of a number
    /// </summary>
    public static class NewtonMethod
    {
        /// <summary>
        /// Calculation accuracy
        /// </summary>
        private static readonly double E = 0.0001;

        /// <summary>
        /// Finds the root of a number
        /// </summary>
        /// <param name="number">Original number</param>
        /// <param name="power">Power of root</param>
        /// <returns>Result rational number</returns>
        public static double FindRoot(double number, double power)
        {
            if (!(number < 0 && power % 2 == 0))
            {
                double xPrev = number / 2;
                double xCurrent = (1 / power) * ((power - 1) * xPrev + number / Math.Pow(xPrev, power - 1));

                while (Math.Abs(xCurrent - xPrev) > E)
                {
                    xPrev = xCurrent;
                    xCurrent = (1 / power) * ((power - 1) * xPrev + number / Math.Pow(xPrev, power - 1));
                }

                return xCurrent;
            }
            else
                throw new Exception("Negative number with even power");
        }
    }
}