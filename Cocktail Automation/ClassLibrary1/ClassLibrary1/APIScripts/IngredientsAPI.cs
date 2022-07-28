using ApiDemo.ApiDtos;
using Newtonsoft.Json;
using RestSharp;
using System;


namespace APIAutomationDemo.APIScripts
{
    public class IngredientsAPI
    {
        public ListOfIngredientDTO GetIngredients(string url, string ingredient )
        {
            var restClient = new RestClient(url);
            var restRequest = new RestRequest("/api/json/v1/1/search.php?i="+ ingredient, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var ingredients = JsonConvert.DeserializeObject<ListOfIngredientDTO>(content);
            return ingredients;

        }

    }
}
