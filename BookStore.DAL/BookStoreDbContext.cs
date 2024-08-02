using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
}