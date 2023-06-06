﻿using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } 
    }

}
