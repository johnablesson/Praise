using Microsoft.EntityFrameworkCore;
using Praize.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.DataAccess
{
    public class PraizeContext : DbContext
    {
        public PraizeContext(DbContextOptions<PraizeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            BuildUser(modelBuilder);
            BuildAddress(modelBuilder);
            BuildAddressType(modelBuilder);
            BuildPhoneNumber(modelBuilder);
            BuildRole(modelBuilder);
        }

        private static void BuildRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
              .Property(b => b.CreatedDate)
              .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Role>()
                    .HasIndex(u => u.Name)
                    .IsUnique();

            modelBuilder.Entity<Role>().HasData(new Role() { Id = 1, Name = "Super Admin" });
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 2, Name = "Admin" });
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 3, Name = "Manager" });
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 4, Name = "Lead" });
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 5, Name = "Associate" });
        }

        private static void BuildUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(b => b.CreatedDate)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<User>()
                  .HasIndex(u => u.UserName)
                  .IsUnique();

            modelBuilder.Entity<User>()
                 .HasIndex(u => u.Email)
                 .IsUnique();
        }

        private static void BuildAddress(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
               .Property(b => b.CreatedDate)
               .HasDefaultValueSql("GETUTCDATE()");
        }

        private static void BuildPhoneNumber(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneNumber>()
              .Property(b => b.CreatedDate)
              .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<PhoneNumber>()
                .HasIndex(u => u.Number)
                .IsUnique();
        }

        private static void BuildAddressType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressType>()
              .Property(b => b.CreatedDate)
              .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<AddressType>()
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<AddressType>().HasData(new AddressType() { Id = 1, Name ="Current" });
            modelBuilder.Entity<AddressType>().HasData(new AddressType() { Id = 2, Name = "Permanent" });

        }

        DbSet<Address> Addresses { get; set; }

        DbSet<AddressType> AddressTypes { get; set; }

        DbSet<PhoneNumber> PhoneNumbers { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<Role> Roles { get; set; }
       
    }
}
