using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticNS;

namespace ArithmeticTests
{
    [TestClass]
    public class ArithmeticTests
    {
        [TestMethod]
        public void TestSumm()
        {
            double a = 5;
            double b = 3;
            double expected = 8;

            Arithmetic arithmetic = new Arithmetic();
            double actual = arithmetic.Summ(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinus()
        {
            double a = 5;
            double b = 3;
            double expected = 2;

            Arithmetic arithmetic = new Arithmetic();
            double actual = arithmetic.Minus(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiply()
        {
            double a = 5;
            double b = 3;
            double expected = 15;

            Arithmetic arithmetic = new Arithmetic();
            double actual = arithmetic.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivide()
        {
            double a = 6;
            double b = 3;
            double expected = 2;

            Arithmetic arithmetic = new Arithmetic();
            double actual = arithmetic.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            double a = 6;
            double b = 0;

            Arithmetic arithmetic = new Arithmetic();
            Assert.ThrowsException<System.DivideByZeroException>(() => arithmetic.Divide(a, b));
        }

        [TestMethod]
        public void TestSquare()
        {
            double a = 4;
            double expected = 16;

            Arithmetic arithmetic = new Arithmetic();
            double actual = arithmetic.Square(a);

            Assert.AreEqual(expected, actual);
        }
    }
}