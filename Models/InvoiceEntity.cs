using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class InvoiceEntity
    {
       
        public string InvoiceID { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string AddressDelivery { get; set; }
        public string CustomerID { get; set; }
        public string StoreID { get; set; }
        public decimal Sale { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal ServiceChange { get; set; }
        public decimal TotalPrice { get; set; }
        public int Status { get; set; }
    }
}
