using Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.ModelsView
{
    public class DiscountVM
    {

        public DiscountVM()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please entre details")]
        public string Details { get; set; }
        [Required(ErrorMessage = "Please entre arabic details")]
        public string Details_ar { get; set; }

        [Required(ErrorMessage = "Please entre percent")]
        public Nullable<double> Percent { get; set; }

        public Nullable<byte> Active { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Modified_At { get; set; }
        public Nullable<System.DateTime> Deleted_At { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}