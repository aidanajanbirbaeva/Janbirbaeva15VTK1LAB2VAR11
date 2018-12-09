using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment1Tests
    {
        private Assignment1 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment1();
        }

        [Test]
        //проверка написания тега фона
        [TestCase("background: [<фон> ]")]//правильный
        [TestCase(" [<фон> ]: background")]//неправильный
        public void CheckCorrectVar(string a)
        { 
            var result = _math.CheckCorrectVar(a);    
            Assert.That(result, Does.StartWith("background")); //ищем тег background
            Assert.That(result, Does.EndWith("]"));
        }
    }
}
