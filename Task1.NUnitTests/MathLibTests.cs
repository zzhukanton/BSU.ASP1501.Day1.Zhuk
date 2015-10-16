using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class MathLibTests
    {
        [TestCase(0, 0 , Result = 1)]
        [TestCase(0, 5, Result = 0)]
        [TestCase(9, 0, Result = 1)]
        [TestCase(64, 3, Result = 4)]
        [TestCase(-27, 3, Result = -3)]
        [TestCase(-81, 2, ExpectedException = typeof(ArgumentException))]
        public double NewtonMethodRoot_FindRootOfNumberWithPower(double number, int power)
        {
            double answer = MathLib.NewtonMethodRoot(number, power);
            return answer;
        }
    }
}
