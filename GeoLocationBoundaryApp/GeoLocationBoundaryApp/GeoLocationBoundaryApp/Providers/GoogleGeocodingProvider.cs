using GeoLocationBoundaryApp.Interfaces;
using GeoLocationBoundaryApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace GeoLocationBoundaryApp.Providers
{
    public class GoogleGeocodingProvider : IGeocodingService
    {
        private readonly string _apiKey;

        public GoogleGeocodingProvider()
        {
            _apiKey = ConfigurationManager.AppSettings["GoogleApiKey"];
        }

        public async Task<List<LocationResult>> GetCoordinatesAsync(string address)
        {
            var results = new List<LocationResult>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var url =
                        $"https://maps.googleapis.com/maps/api/geocode/json?address={Uri.EscapeDataString(address)}&key={_apiKey}";

                    var json = await client.GetStringAsync(url);

                    var data = JObject.Parse(json);

                    var resultArray = data["results"];

                    if (resultArray == null || !resultArray.HasValues)
                        throw new Exception("Coordinates not found.");

                    foreach (var item in resultArray)
                    {
                        var location = item["geometry"]?["location"];

                        results.Add(new LocationResult
                        {
                            Address = item["formatted_address"]?.ToString(),
                            Latitude = location.Value<double>("lat"),
                            Longitude = location.Value<double>("lng")
                        });
                    }
                }

                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching coordinates: " + ex.Message);
                throw;
            }
        }
    }
}