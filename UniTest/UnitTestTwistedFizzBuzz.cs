namespace UniTest

{
    [TestClass]
    public class UnitTestTwistedFizzBuzz
    {
        [TestMethod]
        public void GetFizzBuzzOriginal_ShouldReturnCorrectOutput()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

            var result = twistedFizzBuzz.GetFizzBuzzForRange(1, 15);
            CollectionAssert.AreEqual(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, result);

        }
        [TestMethod]
        public void GetFizzBuzzWithBigNumber_ShouldReturnCorrectOutput()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

            var result = twistedFizzBuzz.GetFizzBuzzForRange(1, 100000);
            Assert.AreEqual(100000, result.Count);

        }
        [TestMethod]
        public void GetFizzBuzzOriginalWithNegativeNumbers_ShouldReturnCorrectOutput()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

            var result = twistedFizzBuzz.GetFizzBuzzForRange(-10, -1);
            CollectionAssert.AreEqual(new List<string> { "Buzz", "Fizz", "-8", "-7", "Fizz", "Buzz", "-4", "Fizz", "-2", "-1" }, result);

        }
        [TestMethod]
        public void GetFizzBuzzWithNumberNonSequential_ShouldReturnCorrectOutput()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

            var result = twistedFizzBuzz.GetFizzBuzzForNumber(new int[] { -5, 6, 300, 12, 15 });

            CollectionAssert.AreEqual(new List<string> { "Buzz", "Fizz", "FizzBuzz", "Fizz", "FizzBuzz"}, result);

        }
        [TestMethod]
        public void GetFizzBuzzWithToken_ShouldReturnCorrectOutput()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

            var result = twistedFizzBuzz.GetFizzBuzzForRange(1, 15);
            CollectionAssert.AreEqual(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, result);

        }
        [TestMethod]
        public async Task GetFizzBuzzApiToken_ShouldReturnCorrectOutput()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

            var result = await twistedFizzBuzz.GetApiTokensOutput(2);
            Assert.AreEqual(2, result.Count);


        }
    }
}