using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ResponseDtos
{
    public class ListOfDrinkCategoriesDTO
    {
        public List<Drink> Drinks { get; set; }
    }

    public partial class Drink
    {
        public string StrCategory { get; set; }
    }


}
