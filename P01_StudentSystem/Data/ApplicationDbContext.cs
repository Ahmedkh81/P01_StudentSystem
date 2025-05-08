using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode();

            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Birthday)
                .IsRequired(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode();

            modelBuilder.Entity<Course>()
                .Property(e => e.Description)
                .IsUnicode()
                .IsRequired(false);

            modelBuilder.Entity<Resource>()
                .Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode();

            modelBuilder.Entity<Resource>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Homework>()
                .Property(e => e.Content)
                .IsUnicode(false);

        }
    }
}
