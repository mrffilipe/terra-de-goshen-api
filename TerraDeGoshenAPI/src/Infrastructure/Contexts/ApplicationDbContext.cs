﻿using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<CategoryRef> Categories { get; set; }
        public DbSet<ColorRef> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<ImageRef> Images { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SizeRef> Sizes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
        }

        public override int SaveChanges()
        {
            SetTimestamps();

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetTimestamps();

            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetTimestamps()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                DateTime dateTime = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.SetCreatedAt(dateTime);
                }

                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    entry.Entity.SetUpdatedAt(dateTime);
                }
            }
        }
    }
}