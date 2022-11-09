//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmacyManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        public Purchase()
        {
            this.Batches = new HashSet<Batch>();
        }
    
        public int ID { get; set; }
        public string Purchase_ID { get; set; }
        public int Amount { get; set; }
        public string Discount { get; set; }
        public double Discount_Amount { get; set; }
        public double Grand_Total { get; set; }
        public string IsPaid { get; set; }
        public System.DateTime Entry_Date { get; set; }
        public string Description { get; set; }
        public int Supplier_ID { get; set; }
    
        public virtual ICollection<Batch> Batches { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
