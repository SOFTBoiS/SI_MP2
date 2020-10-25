using System;

namespace SOAPConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(SOAPClient.Client.GetWeather());
            
        }
    }
}
