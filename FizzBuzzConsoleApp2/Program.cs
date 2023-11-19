using System;
using TwistedFizzBuzz;

class TwistedFizzBuzzDiferent
{
    static void Main()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();
        var output = twistedFizzBuzz.GetFizzBuzzWithAlternativeTokens(-20, 127, new int[] { 5, 9, 27 }, new string[] { "Fizz", "Buzz", "Bar" });


        foreach (var item in output)
        {
            Console.WriteLine(item);
        }

    }
}
