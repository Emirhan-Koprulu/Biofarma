using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu kod araştırmalar sonucu yazılmıştır. Tamamlanmamıştır. Alıntıdır.

            var client = new RestClient(" https://api.saglikbakanligi.gov.tr");
            client.Encoding = UTF8Encoding.UTF8;

            var request = new RestRequest("/HES/dogrula ", Method.POST);

            var list = new List<string>() { "G1B5-6449-15", "G5B2-3442-88" };

            request.AddJsonBody(list);
            request.RequestFormat = DataFormat.Json;

            var serviceResponse = client.Execute(request);

            var responseString = serviceResponse.Content;

            List<string> Lists = new List<string>();

            var x = JsonConvert.DeserializeObject<string>(responseString);

        }
    }
}
