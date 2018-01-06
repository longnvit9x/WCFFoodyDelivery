using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class InvoiceDetailEntity
    {
        public int ID { get; set; }
        public string FoodID { get; set; }
        public int NumberFood { get; set; }
        public string Size { get; set; }
        public decimal PriceSize { get; set; }
        public string Type { get; set; }
        public decimal PriceType { get; set; }
        public string InvoiceID { get; set; }
        public string FoodImage { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
    }
}
