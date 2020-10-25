using System;
using System.Collections.Generic;
using System.Text;

namespace CamundaClientTest.DTOs
{
    class ResponseDTO
    {
        public List<RouteDTO> Routes;
        public List<QuoteDTO> Quotes;
        public List<PlaceDTO> Places;
        public List<CarrierDTO> Carriers;
        public List<CurrencyDTO> Currencies;

        public ResponseDTO(List<RouteDTO> routes, List<QuoteDTO> quotes, List<PlaceDTO> places, List<CarrierDTO> carriers, List<CurrencyDTO> currencies)
        {
            Routes = routes;
            Quotes = quotes;
            Places = places;
            Carriers = carriers;
            Currencies = currencies;
        }
    }
}
