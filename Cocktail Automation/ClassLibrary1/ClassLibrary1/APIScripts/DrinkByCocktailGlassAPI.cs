using ApiDemo.ApiDtos;
using ClassLibrary1.ResponseDtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace APIAutomationDemo.APIScripts
{
    public class DrinkByCocktailGlassAPI
    {
        public ListOfDrinksByCocktailGlassDTO GetDrinkByGlass(string url, string glass)
        {
            var restClient = new RestClient(url);
            var restRequest = new RestRequest("/api/json/v1/1/filter.php?g=" + glass, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var drinksData = JsonConvert.DeserializeObject<ListOfDrinksByCocktailGlassDTO>(content);
            for (int i = 0; i < drinksData.drinks.Count; i++)
            {
                Console.WriteLine(drinksData.drinks[i].strDrink);
                Console.WriteLine(drinksData.drinks[i].strDrinkThumb);
                Console.WriteLine(drinksData.drinks[i].idDrink);
            }
            return drinksData;
            

        }
    }
}
