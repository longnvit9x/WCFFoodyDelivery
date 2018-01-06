using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class FoodSizeEntity
    {
        public int FoodSizeID { get; set; }
        public string SizeName { get; set; }
        public decimal PriceSize { get; set; }
        public string FoodID { get; set; }
    }
}
