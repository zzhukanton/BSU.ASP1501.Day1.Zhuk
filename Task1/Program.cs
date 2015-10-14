using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 27, power1 = 3;
            double number2 = -64, power2 = 3;
            double number3 = -16, power3 = 2;

            double math1 = Math.Pow(number1, (double)1 / power1);
            Console.WriteLine("Result with using Math - {0}", math1);
            double math2 = Math.Pow(number2, (double)1 / power2);
            Console.WriteLine("Result with using Math - {0}", math2);
            double math3 = Math.Pow(number3, (double)1 / power3);
            Console.WriteLine("Result with using Math - {0}", math3);

            try
            {
                double newton1 = NewtonMethod.FindRoot(number1, power1);
                Console.WriteLine("Result with using newton method - {0}", newton1);
                double newton2 = NewtonMethod.FindRoot(number2, power2);
                Console.WriteLine("Result with using newton method - {0}", newton2);
                double newton3 = NewtonMethod.FindRoot(number3, power3);
                Console.WriteLine("Result with using newton method - {0}", newton3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}