using Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.ModelsView
{
    public class CartVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please entre user id")]
        public string User_ID { get; set; }

        [Required(ErrorMessage = "total field is required")]
        public Nullable<decimal> Total { get; set; }

        [Required(ErrorMessage = "Please entre quantity")]
        public Nullable<int> Quantity { get; set; }

        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Modefied_At { get; set; }
        public Nullable<System.DateTime> Deleted_At { get; set; }

        [Required(ErrorMessage = "Please entre product")]
        public long Product_ID { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Product Product { get; set; }
    }
}