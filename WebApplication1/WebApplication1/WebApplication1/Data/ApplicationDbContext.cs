using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Foto> Fotos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            {
                base.OnModelCreating(builder);
                builder.Entity<Event>().ToTable("Event");
                builder.Entity<Foto>().ToTable("Foto");
            }

            builder.Entity<Category_Event>()
                .HasKey(c => new { c.EventId, c.CategoryId });

            builder.Entity<Category_Event>()
                .HasOne(ce => ce.Event)
                .WithMany(e => e.Category_Event)
                .HasForeignKey(ce => ce.EventId);

            builder.Entity<Category_Event>()
                .HasOne(ce => ce.Category)
                .WithMany(c => c.Category_Event)
                .HasForeignKey(ce => ce.CategoryId);
        }
    }
}
