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
    
    public partial class tbl_SUPPDEBTPAYMENT
    {
        public int suppDebtPaymentID { get; set; }
        public Nullable<int> sellerID { get; set; }
        public Nullable<int> suppID { get; set; }
        public Nullable<double> payment { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual tbl_SELLER tbl_SELLER { get; set; }
        public virtual tbl_SUPPLIER tbl_SUPPLIER { get; set; }
    }
}