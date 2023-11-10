using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplication2.Models
{
    public class bkmDbContext : DbContext
    {
        public DbSet<baokem> baokemList { get; set; }
    }
}