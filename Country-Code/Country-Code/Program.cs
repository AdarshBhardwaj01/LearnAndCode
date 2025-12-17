using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> adjacentCountries = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            { "IN", new List<string> { "India", "Pakistan", "China", "Nepal", "Bhutan", "Bangladesh", "Sri Lanka" } },
            { "US", new List<string> { "United State", "Canada", "Mexico" } },
            { "NZ", new List<string> { "Newzealand", "Australia" } },
            { "CA", new List<string> { "California", "United States" } },
            { "AU", new List<string> { "Australia", "New Zealand" } }
        };

            Console.WriteLine("Enter country code ");
            string input = Console.ReadLine();

            string countryCode = input.Trim().ToUpper();

            if (string.IsNullOrEmpty(countryCode))
            {
                Console.WriteLine("Country code cannot be empty.");
                return;
            }

            if (adjacentCountries.ContainsKey(countryCode))
            {
                Console.WriteLine("\nAdjacent Countries:");
                foreach (var country in adjacentCountries[countryCode])
                {
                    Console.WriteLine("- " + country);
                }
            }
            else
            {
                Console.WriteLine($"{countryCode} Not Found");
            }
            Console.ReadLine();
        }
    }
}
