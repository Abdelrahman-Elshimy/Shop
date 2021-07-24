using Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.ModelsView
{
    public class CategoryVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please entre name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please entre arabic name")]
        [Display(Name = "Arabic Name")]
        public string Name_ar { get; set; }

        [Required(ErrorMessage = "Please entre details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Please entre arabic details")]
        public string Details_ar { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Modified_At { get; set; }
        public Nullable<System.DateTime> Deleted_At { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}