using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._1
{
    [TestFixture]
    public class Math_Lab2Tests
    {
        private Math_Lab2 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab2();
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(2));
            Assert.That(result, Does.Contain(4));
            Assert.That(result, Does.Contain(6));

            Assert.That(result, Is.EquivalentTo(new[] { 2, 4, 6 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }



        //не работает
        [TestCase(2, 1, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Add_WhenCalled_ReturnTheSunArguments(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);
            Assert.That(result == expectedResult);
        }

        //работает
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, 3)]
        [TestCase(1, 1, 2)]
        public void Add_WhenCalled_ReturnTheSunOfArguments(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);
            Assert.That(result == expectedResult);
        }
    }
}
