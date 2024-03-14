using CalculatorUnitTest;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void For_Add()
        {
            double a = 4;
            double b = 5;
            Assert.Equal(9,MathematicCalculator.Plus(a,b));
        }
        [Fact]
        public void For_Minus()
        {
            double a = 4;
            double b = 5;
            Assert.Equal(-1,MathematicCalculator.Minus(a,b));
        }
        [Fact]
        public void For_Multiply()
        {
            double a = 4;
            double b = 5;
            Assert.Equal(20, MathematicCalculator.Kopaytiruv(a, b));
        }
        [Fact]
        public void For_Divisor()
        {
            double a = 10;
            double b = 5;
            Assert.Equal(2,MathematicCalculator.Boluv(a,b));
        }
    
    }
}