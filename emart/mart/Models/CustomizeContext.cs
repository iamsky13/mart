using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mart.Models
{
    public class CustomizeContext : DbContext
    {
        public DbSet<Customize> Customize { get; set; }
    }
}