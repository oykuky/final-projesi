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
    
    public partial class tbl_SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SUPPLIER()
        {
            this.tbl_SUPPDEBTPAYMENT = new HashSet<tbl_SUPPDEBTPAYMENT>();
            this.tbl_WAYBILL = new HashSet<tbl_WAYBILL>();
        }
    
        public int suppID { get; set; }
        public string suppName { get; set; }
        public Nullable<double> suppDebt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SUPPDEBTPAYMENT> tbl_SUPPDEBTPAYMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WAYBILL> tbl_WAYBILL { get; set; }
    }
}
