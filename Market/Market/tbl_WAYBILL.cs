//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Market
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_WAYBILL
    {
        public int waybillID { get; set; }
        public Nullable<int> suppID { get; set; }
        public Nullable<int> productID { get; set; }
        public Nullable<int> productBarcode { get; set; }
        public Nullable<double> quantity { get; set; }
        public Nullable<double> inputPrice { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual tbl_PRODUCT tbl_PRODUCT { get; set; }
        public virtual tbl_SUPPLIER tbl_SUPPLIER { get; set; }
    }
}