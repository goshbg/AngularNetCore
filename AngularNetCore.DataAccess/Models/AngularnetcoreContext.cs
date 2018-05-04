using System;
using Microsoft.EntityFrameworkCore;

namespace AngularNetCore.DataAccess.Models
{
    public partial class AngularnetcoreContext : DbContext
    {
        public virtual DbSet<Hero> Heroes { get; set; }

        public AngularnetcoreContext(DbContextOptions<AngularnetcoreContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hero>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
