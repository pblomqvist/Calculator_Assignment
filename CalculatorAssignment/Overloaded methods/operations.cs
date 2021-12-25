using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    class OverloadAddSub
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public double Add(double[] userNums)
        {
            double result = 0;
            foreach (double num in userNums)
            {
                result += num;
            }
            return result;
        }

        public double Sub(double num1, double num2)
        {
            double sum = num1 - num2;
            return sum;
        }

        public double Sub(double[] userNums)
        {
            double sum = 0;
            foreach (int num in userNums)
            {
                sum -= num;
            }
            return sum;
        }

    }
}