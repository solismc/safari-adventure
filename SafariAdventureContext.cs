using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using orm_safari.Models;

namespace safari_adventure
{
    public partial class SafariAdventureContext : DbContext
    {
        public SafariAdventureContext()
        {
        }

        public SafariAdventureContext(DbContextOptions<SafariAdventureContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("server=localhost;database=SafariAdventure");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<SeenAnimals> SeenAnimals {get; set;}
        
    }
}
