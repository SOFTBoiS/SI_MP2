using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamundaClientTest.DTOs;
using Newtonsoft.Json;
using RestSharp;

namespace SimpleCalculationProcess
{
    [ExternalTaskTopic("RequestFlightAndWeather")]
    [ExternalTaskVariableRequirements("DepartureAirport", "ArrivalAirport", "DepartureDate", "AmountOfPassengers")]
    class GetFlightsAndWeather : IExternalTaskAdapter
    {

       public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            string departurenAirport= Convert.ToString(externalTask.Variables["DepartureAirport"].Value);
            string arrivalAirport = Convert.ToString(externalTask.Variables["ArrivalAirport"].Value);
            string departureDate = Convert.ToString(externalTask.Variables["DepartureDate"].Value);
            string amountOfPassengers = Convert.ToString(externalTask.Variables["AmountOfPassengers"].Value);

            var client = new RestClient($"https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/DK/DKK/da/{departurenAirport}-sky/{arrivalAirport}-sky/{departureDate}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "YOUR_RAPID_API_KEY");
            IRestResponse response = client.Execute(request);

            //TODO: Get weather

            // TODO: Go through the ResponseDTO and convert it to a new type of object that makes sense on a frontend
            var responseObject = JsonConvert.DeserializeObject<ResponseDTO>(response.Content);
            var quotesJson = JsonConvert.SerializeObject(responseObject.Quotes);

            resultVariables.Add("Quotes", quotesJson);
            
        }
    }
}
