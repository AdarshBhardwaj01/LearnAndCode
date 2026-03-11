using GeoLocationBoundaryApp.Interfaces;
using GeoLocationBoundaryApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoLocationBoundaryApp.Services
{
    public class LocationService
    {
        private readonly IGeocodingService _geocodingService;

        public LocationService(IGeocodingService geocodingService)
        {
            _geocodingService = geocodingService;
        }

        public async Task<List<LocationResult>> GetLocationAsync(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("Location cannot be empty.");

            return await _geocodingService.GetCoordinatesAsync(location);
        }
    }
}