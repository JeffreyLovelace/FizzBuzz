using System;
using TwistedFizzBuzz;

class TwistedFizzBuzzStandar
{
    static void Main()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz.Controllers.TwistedFizzBuzzController();

        var output = twistedFizzBuzz.GetFizzBuzzForRange(1, 100);

        foreach (var item in output)
        {
            Console.WriteLine(item);
        }

    }
}
