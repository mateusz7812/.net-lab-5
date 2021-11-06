using System;
using Xunit;
using zad1Project;

namespace Tests
{
    public class LinearFunctionTest
    {
        [Fact]
        public void TestCalc()
        {
            var (x1, x2) = Program.Calc(0, 2, 1);
            Assert.Equal(-0.5, x1);
            Assert.Null(x2);
        }

        [Fact]
        public void TestCalc2()
        {
            var (x1, x2) = Program.Calc(0, 3, 3);
            Assert.Equal(-1, x1);
            Assert.Null(x2);
        }

        [Fact]
        public void TestCalcBEqual0()
        {
            var (x1, x2) = Program.Calc(0, 0, 3);
            Assert.Null(x1);
            Assert.Null(x2);
        }

    }
}
