using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._1
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private string error;

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            // logger.Log("a");

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

        }
    }
}
