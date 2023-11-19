using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace UnitTestTwistedFizzBuzz
{
    [TestClass]
    public class LibraryTwistedFizzBuzzTest
    {
        [TestMethod]
        public void GetFizzBuzzOriginal_ShouldReturnCorrectOutput()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

            var result = twistedFizzBuzz.GetFizzBuzzForRange(1, 100);

            Assert.Equal(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, result);

        }
    }
}
