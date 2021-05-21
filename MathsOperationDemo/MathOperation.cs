using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsOperationDemo
{
    public class MathOperation
    {
        public double Add(double a, double b)
        {
            double output = a + b;
            return output;
        }
        public double Subtract(double a, double b)
        {
            double output = a - b;
            return output;
        }
        public double Divide(double a, double b)
        {
            double output = 0;
            if (b != 0)
            {
                output = a / b;
            }
            return output;
        }
        public double Multiply(double a, double b)
        {
            double output = a * b;
            return output;
        }
    }
}
