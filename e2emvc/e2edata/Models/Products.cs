using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e2edata.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}