    using System;
using APIAutomationDemo.APIScripts;
using ClassLibrary1.APIScripts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITests
{
    [TestClass]
    public class DemoApiTests
    {
        public string url = "http://www.thecocktaildb.com";
        [TestMethod]
        [DataRow("Vodka")]
        [DataRow("water")]
        public void SearchByIngredientsAlcohol(string ingredie)
        {          
 
            var ingredients = new IngredientsAPI();
            var response = ingredients.GetIngredients(url, ingredie);
            Console.WriteLine("Ingredient " + ingredie + " is an alcohol: " + response.Ingredients[0].StrAlcohol);
            Console.WriteLine(ingredie + " ABV value is: "+response.Ingredients[0].StrAbv);
        }
        
        [TestMethod]
        [DataRow("Smashed Watermelon Margarita")]
        [DataRow("Choclate")]
        public void SearchCoktailByName(string cocktail)
        {
            var ctail = new CocktailAPI();
            var response = ctail.GetCockail(url, cocktail);
        }

        [TestMethod]
        public void GetDrinksCategory()
        {
            var category = new DrinkCategoryAPI();
            var response = category.GetCategory(url);
        }

        [TestMethod]
        [DataRow("Cocktail_glass")]
        public void SearchDrinksByCocktailGlass(string glass)
        {
            var ctail = new DrinkByCocktailGlassAPI();
            var response = ctail.GetDrinkByGlass(url, glass);
        }
    }
}
