using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class CategoryRevenue
    {
        //public int CategoryID { get; set; }
        [Key]
        public string ProductName { get; set; }
        public double Revenue { get; set; }
    }
}
