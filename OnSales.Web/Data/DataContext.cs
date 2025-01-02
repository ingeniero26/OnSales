﻿using Microsoft.EntityFrameworkCore;
using OnSales.Web.Data.Entities;

namespace OnSales.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}
