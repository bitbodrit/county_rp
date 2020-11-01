﻿using Microsoft.EntityFrameworkCore;

using CountyRP.DAO;

namespace CountyRP.WebAPI.Models
{
    public class LogContext : DbContext
    {
        public DbSet<LogUnit> LogUnits { get; set; }

        public LogContext(DbContextOptions<LogContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}