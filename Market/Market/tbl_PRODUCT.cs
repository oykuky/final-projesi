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
    
    public partial class tbl_PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PRODUCT()
        {
            this.tbl_WAYBILL = new HashSet<tbl_WAYBILL>();
        }
    
        public int productID { get; set; }
        public Nullable<int> productBrakod { get; set; }
        public string productName { get; set; }
        public Nullable<double> productPrice { get; set; }
        public Nullable<double> productStock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WAYBILL> tbl_WAYBILL { get; set; }
    }
}
