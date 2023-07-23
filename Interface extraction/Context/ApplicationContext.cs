﻿
using CQRS.WebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CQRS.WebApi.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

    }
}
