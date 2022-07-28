
using System.Collections.Generic;


namespace ApiDemo.ApiDtos
{
    public class ListOfIngredientDTO
    {   
        public List<Ingredient> Ingredients { get; set; }
    }

    public partial class Ingredient
    {
        public string IdIngredient { get; set; }
        public string StrIngredient { get; set; }
        public string StrDescription { get; set; }
        public string StrType { get; set; }
        public string StrAlcohol { get; set; }
        public int? StrAbv { get; set; }
    }
}

