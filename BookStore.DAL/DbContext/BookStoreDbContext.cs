using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {

    }

    public DbSet<Store> Stores => Set<Store>();
    public DbSet<Storage> Storages => Set<Storage>();
    public DbSet<Chain> Chains => Set<Chain>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Store>()
            .HasOne(e => e.Storage)
            .WithOne(e => e.Store)
            .HasForeignKey<Store>(e => e.StorageId);
    }

    public sealed override int SaveChanges()
    {
        // Update dates
        SaveChanges();
        return 1;
    }
}