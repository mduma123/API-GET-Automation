using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ResponseDtos
{
    public class ListOfDrinksByCocktailGlassDTO
    {
        public List<DrinksItem> drinks { get; set; }
    }
    public class DrinksItem
    {
        public string strDrink { get; set; }
        public string strDrinkThumb { get; set; }
        public string idDrink { get; set; }
    }

   
    
}
