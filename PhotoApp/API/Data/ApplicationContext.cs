using DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>().HasKey(i => i.ID);
            modelBuilder.Entity<Photo>().Property(i => i.Title).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Photo>().Property(i => i.OwnerId).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Photo>().Property(i => i.Filename).HasMaxLength(200).IsRequired();
        }
    }
}
