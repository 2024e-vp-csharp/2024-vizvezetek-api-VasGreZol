using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using Vizvezetek.API.Models;

namespace Vizvezetek.API.Context;

public partial class VizvezetekContext : DbContext
{
    public VizvezetekContext()
    {
    }

    public VizvezetekContext(DbContextOptions<VizvezetekContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hely> hely { get; set; }

    public virtual DbSet<Munkalap> munkalap { get; set; }

    public virtual DbSet<Szerelo> szerelo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;user=root;database=vizvezetek", ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Hely>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Munkalap>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasOne(d => d.hely).WithMany(p => p.munkalap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("munkalap_ibfk_1");

            entity.HasOne(d => d.szerelo).WithMany(p => p.munkalap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("munkalap_ibfk_2");
        });

        modelBuilder.Entity<Szerelo>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
