using Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.ModelsView
{
    public class AddressVM
    {
        [Key]
        public int Id { get; set; }

        public string User_ID { get; set; }

        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string City { get; set; }
        public Nullable<int> Postal_Code { get; set; }
        public string Country { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}