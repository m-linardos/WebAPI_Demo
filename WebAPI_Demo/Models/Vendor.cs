using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Demo.Models
{
    public class Vendor
    {
        [Key]
        public int VendID { get; set; }
        [MaxLength(50)]
        public string Name  { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(2)]
        public string State { get; set; }
        [MaxLength(10)]
        public string Zip{ get; set; }
    }
}
