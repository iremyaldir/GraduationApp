using GraduationApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Alumni> Alumnies {get;set;}
        public DbSet<AlumniPrivacySetting> AlumniPrivacySettings {get;set;}
        public DbSet<AlumniRegistration> AlumniRegistrations { get;set;}
        public DbSet<AlumniRole> AlumniRoles { get;set;}
        public DbSet<Announcement> Announcements { get;set;}
        public DbSet<Department> Departments { get;set;}
        public DbSet<JobPost> JobPosts { get;set;}
        public DbSet<Role> Roles { get;set;}
        public DbSet<Term> Terms { get;set;}
        public DbSet<User> Users { get;set;}
        public DbSet<UserPrivacySetting> UserPrivacySettings { get;set;}
        public DbSet<UserRegistration> UserRegistrations { get;set;}
        public DbSet<UserRole> UserRoles { get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumni>()
            .HasOne(a => a.Term) // Navigation property in Alumni
            .WithOne(t => t.Alumni) // Navigation property in Term (optional)
            .HasForeignKey<Alumni>(a => a.TermId); // Foreign key property in Alumni
        }


    }
}
