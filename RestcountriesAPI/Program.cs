using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestcountriesAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://restcountries.eu/rest/v2/name/eesti";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
               
              List<GetData> data = JsonConvert.DeserializeObject<List<GetData>>(response);


                Console.WriteLine($"Name: {data[0].Name}");
                Console.WriteLine($"Cioc: {data[0].Cioc}");
                Console.WriteLine($"Domain: {data[0].TopLevelDomain[0]}");
                Console.WriteLine($"Capital: {data[0].Capital}");
                Console.WriteLine($"Region: {data[0].Region}");
                Console.WriteLine($"Population: {data[0].Population}");
                Console.WriteLine($"Language: {data[0].Languages[0].NativeName}");

            }
        }
    }
}
