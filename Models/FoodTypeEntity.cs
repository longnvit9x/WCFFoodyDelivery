using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class FoodTypeEntity
    {
        public int FoodTypeID { get; set; }
        public string TypeName { get; set; }
        public decimal PriceType { get; set; }
        public string FoodID { get; set; }
    }
}
