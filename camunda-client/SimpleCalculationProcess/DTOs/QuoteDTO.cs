using System;
using System.Collections.Generic;
using System.Text;

namespace CamundaClientTest
{
    class QuoteDTO
    {
        public string QuoteId, MinPrice;
        public OutboundLeg OutboundLeg;
        public DateTime QuoteDateTime;

        public QuoteDTO(string quoteId, string minPrice, OutboundLeg outboundLeg, DateTime quoteDateTime)
        {
            QuoteId = quoteId;
            MinPrice = minPrice;
            OutboundLeg = outboundLeg;
            QuoteDateTime = quoteDateTime;
        }

        public override string ToString()
        {
            return
                $"{{QuoteId: {QuoteId}, MinPrice: {MinPrice}, OutboundLeg: {OutboundLeg}, QuoteDateTime: {QuoteDateTime}}}";
        }
    }



    internal class OutboundLeg
    {
        public List<int> CarrierIds;
        public int OriginId, DestinationId;
        public DateTime DepartureDate;

        public OutboundLeg(List<int> carrierIds, int originId, int destinationId, DateTime departureDate)
        {
            CarrierIds = carrierIds;
            OriginId = originId;
            DestinationId = destinationId;
            DepartureDate = departureDate;
        }
        public override string ToString()
        {
            return
                $"{{CarrerIds: {CarrierIds.ToString()}, OriginId: {OriginId}, DestinationId: {DestinationId}, DepartureDate: {DepartureDate}}}";
        }

    }
}
