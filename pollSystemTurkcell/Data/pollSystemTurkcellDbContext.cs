using Microsoft.EntityFrameworkCore;
using pollSystemTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Data
{
    public class pollSystemTurkcellDbContext : DbContext
    {
        public pollSystemTurkcellDbContext(DbContextOptions<pollSystemTurkcellDbContext> options) : base(options)
        { 
        
        }
        
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Poll>().HasMany(q => q.Questions)
                                       .WithOne(p => p.Poll)
                                       .HasForeignKey(k => k.PollID);
                                       
           
            modelBuilder.Entity<User>().HasOne(r => r.UserRole)
                                       .WithMany(u => u.Users)
                                       .HasForeignKey(f => f.UserRoleID);
           
            modelBuilder.Entity<PollUser>().HasKey(pu => new { pu.PollID, pu.UserID });

            modelBuilder.Entity<PollUser>().HasOne(p => p.Poll)
                                           .WithMany(u => u.User)
                                           .HasForeignKey(k => k.PollID);


            modelBuilder.Entity<PollUser>().HasOne(u => u.User)
                                           .WithMany(p => p.Poll)
                                           .HasForeignKey(f => f.UserID);


            base.OnModelCreating(modelBuilder);
        }

    
    }
}
