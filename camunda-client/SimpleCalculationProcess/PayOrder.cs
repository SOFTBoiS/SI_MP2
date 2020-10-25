using CamundaClient.Dto;
using CamundaClient.Worker;
using CamundaClientTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SimpleCalculationProcess
{
    [ExternalTaskTopic("PayOrder")]
    [ExternalTaskVariableRequirements("quotes", "SelectedFlight", "CardNumber")]
    class PayOrder : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            //Load selected flight and card number
            var QuotesJson = (string)externalTask.Variables["quotes"].Value;
            long s1 = Convert.ToInt64(externalTask.Variables["SelectedFlight"].Value);
            long s2 = Convert.ToInt64(externalTask.Variables["CardNumber"].Value);
            var Quotes = JsonConvert.DeserializeObject<List<QuoteDTO>>(QuotesJson);
            var index = Convert.ToInt32(s1);
            Console.WriteLine($"Paid for flights using Credit Card: {s2}");
            Console.WriteLine("Flight with the following info has been paid for.");
            Console.WriteLine(Quotes[index - 1]);

            //
            resultVariables.Add("Quotes", QuotesJson);
        }
    }
}
