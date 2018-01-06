using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StoreEntity
    {
        public string StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string OpenDoor { get; set; }
        public string CloserDoor { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal ShippingFee { get; set; }
        public string Manner { get; set; }
        public string Website { get; set; }
        public string StoreType { get; set; }
        public string StoreBanner { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double Rating { get; set; }
        public int Evaluation { get; set; }
        public decimal ConditionShip { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int FileID { get; set; }
    }
}
