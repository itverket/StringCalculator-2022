using NUnit.Framework;

namespace StringCalculator
{
    public class StringCalculator
    {
        public void Add() {}
    }

    [TestFixture]
    public class StringCalculatorTests
    {

        [Test]
        public void Add_Test()
        {
            var sc = new StringCalculator();
            sc.Add();
        }
    }
}
