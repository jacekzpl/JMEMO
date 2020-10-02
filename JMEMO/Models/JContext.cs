using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JMEMO.Models
{
    public class JContext : DbContext
    {
        public JContext(DbContextOptions<JContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Task> Tasks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Language>().ToTable("Languages");
            modelBuilder.Entity<Text>().ToTable("Texts");
            modelBuilder.Entity<Task>().ToTable("Tasks");
        }
    }
}
