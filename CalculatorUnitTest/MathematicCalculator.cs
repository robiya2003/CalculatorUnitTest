using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTest
{
    public static class MathematicCalculator
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Kopaytiruv(double a, double b)
        {
            return a * b;
        }
        public static double Boluv(double a, double b)
        {
            if (a == 0 && b==0)
            {
                throw new NullReferenceException("nolga bolib bolmaydi");
            }
            return a % b;
        }
    }
}
