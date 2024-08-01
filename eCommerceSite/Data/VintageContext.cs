﻿using Microsoft.EntityFrameworkCore;
using eCommerceSite.Models;

namespace eCommerceSite.Data
{
    public class VintageContext : DbContext 
    {
        public VintageContext(DbContextOptions<VintageContext>options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}