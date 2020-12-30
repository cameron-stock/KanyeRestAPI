using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeRestAPI
{
    public class QuoteGenerator
    {
        public static string GetKanye()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            Console.WriteLine(kanyeResponse);


            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            return kanyeQuote;
        }
    }
}
