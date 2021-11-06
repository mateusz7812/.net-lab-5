using Xunit;
using zad1Project;

namespace Tests
{
    public class SquareFunctionTest
    {        
        [Fact]
        public void TestCalcNoResults()
        {
            var (x1, x2) = Program.Calc(1.1, 0, 3.3);
            Assert.Null(x1);
            Assert.Null(x2);
        }
        
        [Fact]
        public void TestCalcOneResult()
        {
            var (x1, x2) = Program.Calc(1.1, 0, 0);
            Assert.Equal(0, x1);
            Assert.Null(x2);
        }

        [Fact]
        public void TestCalcTwoResults()
        {
            var (x1, x2) = Program.Calc(1, 0, -1);
            Assert.Equal(-1, x1);
            Assert.Equal(1, x2);
        }
    }
}