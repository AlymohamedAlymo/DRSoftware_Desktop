//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DRSoftware_lib.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class pricing
    {
        public int IDMove { get; set; }
        public int IDItem { get; set; }
        public string DateMove { get; set; }
        public decimal SupplyPrice { get; set; }
        public Nullable<decimal> WholesPrice { get; set; }
        public Nullable<decimal> HalfWhoPr { get; set; }
        public decimal SellingPr { get; set; }
        public string DetMove { get; set; }
    }
}
