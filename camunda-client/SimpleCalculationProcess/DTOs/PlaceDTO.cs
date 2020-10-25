using System;
using System.Collections.Generic;
using System.Text;

namespace CamundaClientTest
{
    class PlaceDTO
    {
        public int PlaceId;
        public string IataCode, Name, Type, SkyscannerCode, CityName, CityId, CountryName;

        public PlaceDTO(int placeId, string iataCode, string name, string type, string skyscannerCode, string cityName, string cityId, string countryName)
        {
            PlaceId = placeId;
            IataCode = iataCode;
            Name = name;
            Type = type;
            SkyscannerCode = skyscannerCode;
            CityName = cityName;
            CityId = cityId;
            CountryName = countryName;
        }
    }
}
