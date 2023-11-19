using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwistedFizzBuzz.Services;

namespace TwistedFizzBuzz.Controllers
{
    public class TwistedFizzBuzzController
    {
        public List<string> GetFizzBuzzForRange(int start, int end)
        {
            var result = new List<string>();
            var twistedFizzBuzzService = new TwistedFizzBuzzService();
            for (int i = start; i <= end; i++)
            {
                string output = twistedFizzBuzzService.GetFizzBuzzValue(i);
                result.Add(output);
            }
            return result;
        }
        public List<string> GetFizzBuzzForNumber(int[] numbers)
        {
            var result = new List<string>();
            var twistedFizzBuzzService = new TwistedFizzBuzzService();

            for (int i = 0; i < numbers.Length; i++)
            {
                string output = twistedFizzBuzzService.GetFizzBuzzValue(numbers[i]);
                result.Add(output);
            }

            return result;
        }

        public List<string> GetFizzBuzzWithAlternativeTokens(int start, int end, int[] divisors, string[] tokens)
        {
            var result = new List<string>();
            var twistedFizzBuzzService = new TwistedFizzBuzzService();

            for (int i = start; i <= end; i++)
            {
                string output = twistedFizzBuzzService.GetFizzBuzzValueWithTokens(i, divisors, tokens);
                result.Add(output);
            }

            return result;
        }

        public async Task<List<string>> GetApiTokensOutput(int amount)
        {
            var result = new List<string>();
            var twistedFizzBuzzService = new TwistedFizzBuzzService();

            for (int i = 0; i < amount; i++)
            {
                string response = await twistedFizzBuzzService.GetToken();
                result.Add(response);
            }
            return result;

        }
    }
}
