using GeoLocationBoundaryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocationBoundaryApp.Interfaces
{
    public interface IGeocodingService
    {
        Task<List<LocationResult>> GetCoordinatesAsync(string location);
    }
}
