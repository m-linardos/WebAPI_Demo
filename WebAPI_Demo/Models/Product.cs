using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Demo.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

    }
}
