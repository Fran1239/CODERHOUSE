using System;
using System.Collections.Generic;
using CRM_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_DAL.Database;

public partial class CoderContext : DbContext
{
    public CoderContext()
    {
    }

    public CoderContext(DbContextOptions<CoderContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SoldProduct> SoldProducts { get; set; }

    public virtual DbSet<Userr> Userrs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=CoderHouse;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC079C46F954");

            entity.ToTable("Product");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descriptions).IsUnicode(false);
            entity.Property(e => e.Names).IsUnicode(false);
            entity.Property(e => e.Prices).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SalePrices).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sale__3214EC07AE0C25A4");

            entity.ToTable("Sale");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.DateTimes).IsUnicode(false);
        });

        modelBuilder.Entity<SoldProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SoldProd__3214EC070FC2FF8E");

            entity.ToTable("SoldProduct");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Stock).IsUnicode(false);
        });

        modelBuilder.Entity<Userr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Userr__3214EC077BDB7AAB");

            entity.ToTable("Userr");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Emails).IsUnicode(false);
            entity.Property(e => e.LastNames).IsUnicode(false);
            entity.Property(e => e.Names).IsUnicode(false);
            entity.Property(e => e.Passwords).IsUnicode(false);
            entity.Property(e => e.UserNames).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
