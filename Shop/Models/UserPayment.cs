//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserPayment()
        {
            this.Order_Details = new HashSet<Order_Details>();
        }
    
        public int Id { get; set; }
        public string User_ID { get; set; }
        public string Payment_Type { get; set; }
        public string Provider { get; set; }
        public Nullable<System.DateTime> Expire_Data { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
    }
}
