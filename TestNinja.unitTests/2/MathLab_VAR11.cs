using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class MathLab_VAR11
    { 
            private Math_Lab1 c;
            [SetUp]
            public void SetUp()
            {
                c = new Math_Lab1();
            }

            [Test]

            [TestCase(6, 3, true)]
            [TestCase(8, 3, false)]
            public void IsDifferenceDivisibleBy3(int a, int b, bool DifferenceGreater)
            {
                //Act  
                var result = c.IsDifferenceDivisibleBy3(a, b);

                //Assert 
                Assert.That(result == DifferenceGreater);
            }
    }
}