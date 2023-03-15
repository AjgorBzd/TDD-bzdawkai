using NUnit.Framework;
using se_kalkulator;

namespace se_kalkulator_test
{
    public class Tests
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        
        [TestCase("5,8")]
        public void Test1(string value)
        {
            int a = calculator.Add(value);
            int expected = 13;
            Assert.AreEqual(expected, a);
        }
    }
}