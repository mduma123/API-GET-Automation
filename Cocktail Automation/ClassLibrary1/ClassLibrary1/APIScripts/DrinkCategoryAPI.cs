using ClassLibrary1.ResponseDtos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.APIScripts
{
    public class DrinkCategoryAPI
    {
        public ListOfDrinkCategoriesDTO GetCategory(string url)
        {
            var restClient = new RestClient(url);
            var restRequest = new RestRequest("/api/json/v1/1/list.php?c=list", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var catagoryData = JsonConvert.DeserializeObject<ListOfDrinkCategoriesDTO>(content);
            for(int i=0;i<catagoryData.Drinks.Count; i++)
            {
                Console.WriteLine(catagoryData.Drinks[i].StrCategory);
            }
            return catagoryData;

        }
    }
}
