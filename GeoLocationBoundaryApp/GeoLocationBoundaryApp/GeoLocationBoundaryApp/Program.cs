using GeoLocationBoundaryApp.Interfaces;
using GeoLocationBoundaryApp.Providers;
using GeoLocationBoundaryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocationBoundaryApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter location: ");
            string location = Console.ReadLine();

            IGeocodingService provider = new GoogleGeocodingProvider();

            var locationService = new LocationService(provider);

            try
            {
                var results = await locationService.GetLocationAsync(location);

                if (results.Count == 0)
                {
                    Console.WriteLine("No results found.");
                    return;
                }

                Console.WriteLine("\nResults:\n");

                foreach (var result in results)
                {
                    Console.WriteLine("Address   : " + result.Address);
                    Console.WriteLine("Latitude  : " + result.Latitude);
                    Console.WriteLine("Longitude : " + result.Longitude);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
