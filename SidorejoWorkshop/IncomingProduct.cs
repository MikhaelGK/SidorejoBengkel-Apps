//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SidorejoWorkshop
{
    using System;
    using System.Collections.Generic;
    
    public partial class IncomingProduct
    {
        public int IncomingProductId { get; set; }
        public System.DateTime Date { get; set; }
        public string ProductId { get; set; }
        public int Qty { get; set; }
        public int BuyPrice { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    
        public virtual Product Product { get; set; }
    }
}