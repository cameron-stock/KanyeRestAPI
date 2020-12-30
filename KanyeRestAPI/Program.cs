using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeRestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            Console.WriteLine(kanyeResponse);

 

        }
    }
}
