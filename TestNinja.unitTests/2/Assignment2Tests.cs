using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment2Tests
    {
        private Assignment2 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment2();
        }

        [Test]
        [TestCase(40, new int[] { 0,1,4, 9, 16, 25, 36}, TestName = "Первый массив")]
        [TestCase(40, new int[] { 6, 14, 24, 31, 41 }, TestName = "Второй массив")]
        //Проверка корня до 40
        public void CheckNumbersInMassiv(int lim, int[] mass)
        {
            var result = _math.GetOddNumbers(lim);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.EqualTo(mass)); //Проверка найденных чисел 
        }
    }
}
