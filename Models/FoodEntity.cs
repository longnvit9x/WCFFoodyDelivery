using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class FoodEntity
    {
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string FoodImage { get; set; }
        public string CategoryID { get; set; }
        public string StoreID { get; set; }
    }
}
