using ApiDemo.ApiDtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationDemo.APIScripts
{
    public class CocktailAPI
    {
        public ListOfcocktailDTO GetCockail(string url, string cocktail)
        {
            var restClient = new RestClient(url);
            var restRequest = new RestRequest("/api/json/v1/1/search.php?s=" + cocktail, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            if (content != null)
            {
                JObject parsed = JObject.Parse(content);
                foreach (var pair in parsed)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }
            }
            var cocktailData = JsonConvert.DeserializeObject<ListOfcocktailDTO>(content);
            return cocktailData;
            

        }
    }
}
