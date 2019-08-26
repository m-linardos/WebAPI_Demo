using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Demo.Models            // not a poco - inherits from DBContext
{
    public class WebServiceDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }          // Dependancy Injection requires constructor

        public WebServiceDB(DbContextOptions options) : base(options)
        {

        }
    }
}
