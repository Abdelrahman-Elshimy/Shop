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
    
    public partial class Order
    {
        public int Id { get; set; }
        public Nullable<int> Order_ID { get; set; }
        public Nullable<long> Product_ID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Modefied_At { get; set; }
        public Nullable<System.DateTime> Deleted_At { get; set; }
    
        public virtual Order_Details Order_Details { get; set; }
        public virtual Product Product { get; set; }
    }
}
