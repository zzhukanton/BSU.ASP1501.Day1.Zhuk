using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Class for math operations
    /// </summary>
    public static class MathLib
    {
        /// <summary>
        /// Calculation accuracy
        /// </summary>
        private static readonly double E = 0.00001;

        /// <summary>
        /// Finds the root of a number by Newton method
        /// </summary>
        /// <param name="number">Original number</param>
        /// <param name="power">Power of root</param>
        /// <returns>Result rational number</returns>
        public static double NewtonMethodRoot(double number, double power)
        {
            if (power == 0)
                return 1;


            if (number == 0 && power != 0)
                return 0;

            if (number < 0 && power % 2 == 0)
                throw new ArgumentException("Negative number with even power");
            else
            {
                double xPrev = number / 2;
                double xCurrent = (1 / power) * ((power - 1) * xPrev + number / Math.Pow(xPrev, power - 1));

                while (Math.Abs(xCurrent - xPrev) > E)
                {
                    xPrev = xCurrent;
                    xCurrent = (1 / power) * ((power - 1) * xPrev + number / Math.Pow(xPrev, power - 1));
                }
                
                return Math.Round(xCurrent, (int)Math.Log10(1/E));
            }
        }
    }
}
