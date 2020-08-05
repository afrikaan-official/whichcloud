using System;
using Microsoft.EntityFrameworkCore;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.data
{
    public class ResourceContext : DbContext
    {
        public DbSet<VMType> VMTypes { get; set; }
        public DbSet<VM> VMs { get; set; }
        
        public DbSet<Source> Sources { get; set; }

        public ResourceContext(DbContextOptions options)
            :base(options)
        {
            
        }
        
    }
}