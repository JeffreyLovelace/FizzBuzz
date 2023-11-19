using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TwistedFizzBuzz.Services
{
    internal class TwistedFizzBuzzService
    {

        static HttpClient client = new HttpClient();
        public static IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json").Build();

        public static string url = configuration["ApiUrl"];
        public string GetFizzBuzzValue(int number)
        {
       

            
            int[] divisors = { 3, 5 };
            string[] tokens = { "Fizz", "Buzz" };

            string output = "";

            for (int j = 0; j < divisors.Length; j++)
            {
                if (number % divisors[j] == 0)
                {
                    output += tokens[j];
                }
            }
            if (IsMultipleOfAllDivisors(number, divisors))
            {
                output = string.Join("", tokens);
            }
            return string.IsNullOrEmpty(output) ? number.ToString() : output;

        }
        public string GetFizzBuzzValueWithTokens(int number, int[] divisors, string[] tokens)
        {
            string output = "";

            for (int j = 0; j < divisors.Length; j++)
            {
                if (number % divisors[j] == 0)
                {
                    output += tokens[j];
                }
            }
            if (IsMultipleOfAllDivisors(number, divisors)) 
            {
                output = string.Join("", tokens);
            }
            return string.IsNullOrEmpty(output) ? number.ToString() : output;
        }

        public async Task<string> GetToken()
        {
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string token = await response.Content.ReadAsStringAsync();
                    return token;
                }
                else
                {
                    return "Error";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return "Error";
            }
        }
        private bool IsMultipleOfAllDivisors(int number, int[] divisors)
        {
            foreach (int divisor in divisors)
            {
                if (number % divisor != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
