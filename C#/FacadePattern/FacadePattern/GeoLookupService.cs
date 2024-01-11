using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class GeoLookupService
    {
        public Location GetLocationByCity(string city)
        {
            return new Location(15, 20);
        }
    }
}
