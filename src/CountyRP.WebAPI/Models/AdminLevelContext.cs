﻿using Microsoft.EntityFrameworkCore;

using CountyRP.Entities;

namespace CountyRP.WebAPI.Models
{
    public class AdminLevelContext : DbContext
    {
        public DbSet<AdminLevel> AdminLevels { get; set; }

        public AdminLevelContext(DbContextOptions<AdminLevelContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}