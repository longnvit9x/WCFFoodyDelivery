//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceDetail
    {
        public int ID { get; set; }
        public Nullable<System.Guid> FoodID { get; set; }
        public Nullable<int> NumberFood { get; set; }
        public string Size { get; set; }
        public Nullable<decimal> PriceSize { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> PriceType { get; set; }
        public Nullable<System.Guid> InvoiceID { get; set; }
    
        public virtual Food Food { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
