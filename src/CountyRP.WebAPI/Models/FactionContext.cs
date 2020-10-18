﻿using Microsoft.EntityFrameworkCore;

using CountyRP.DAO;

namespace CountyRP.WebAPI.Models
{
    public class FactionContext : DbContext
    {
        public DbSet<Faction> Factions { get; set; }
        public DbSet<LockerRoom> LockerRooms { get; set; }

        public FactionContext(DbContextOptions<FactionContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
