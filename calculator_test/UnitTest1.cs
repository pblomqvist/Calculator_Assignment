using System;
using Xunit;
using CalculatorAssignment;
using Operations;

namespace calculator_test
{
    public class UnitTest1
    {

        OverloadAddSub overloaded = new OverloadAddSub();

        [Fact]
        public void AddTest()
        {

            double num1 = 5;
            double num2 = 4;
            double expectedResult = 9;

            double result = overloaded.Add(num1, num2);

            Assert.Equal(expectedResult, result);
        }


        [Fact]
        public void SubtractTest()
        {

            double num1 = 5;
            double num2 = 5;
            double expectedResult = 0;

            double result = overloaded.Sub(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MultiplyTest()
        {

            double num1 = 5;
            double num2 = 4;
            double expectedResult = 20;

            double result = Program.Multiply(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DivideByZeroTest()
        {

            double num1 = 5;
            double num2 = 0;
            var expectedResult = Assert.Throws<DivideByZeroException>(
                () => Program.Division(num1, num2));

            Assert.Equal("Can't divide by 0, enter another number.", expectedResult.Message);
        }

        [Theory]
        [InlineData(6,2,3)]
        public void DivideTestTheory(double num1, double num2, double expected)
        {
            double result = Program.Division(num1, num2);
            Assert.Equal(expected, result, 4);
        }

        [Fact]
        public void AddArrayTest()
        {
            
            double expected = 13;
            double[] numInputs = new double[] { 2, 5, 6 };
            

            double result = addNum.Add(numInputs);
            Assert.Equal(expected, result);

        }

        [Fact]
        public void SubArrayTest()
        {

            double expected = -13;
            double[] numInputs = new double[] { 2, 5, 6 };
            OverloadAddSub addNum = new OverloadAddSub();

            double result = addNum.Sub(numInputs);
            Assert.Equal(expected, result);

        }

        [Fact]
        public void PowerOfTest()
        {

            double num1 = 6;
            double num2 = 6;
            double expectedResult = 46656;

            double result = Program.PowerOf(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SquareTest()
        {

            double num1 = 4;
            double expectedResult = 2;

            double result = Program.SquareRoot(num1);

            Assert.Equal(expectedResult, result);
        }

    }
}
