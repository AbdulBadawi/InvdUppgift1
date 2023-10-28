using System;
using System.Collections.Generic;
using InvdUppgift1;
using Microsoft.EntityFrameworkCore;

namespace InvdUppgift1.Modelss.HP.Documents.GitHub.InvdUppgift1;

public partial class ArtistdbContext : DbContext
{
    public ArtistdbContext()
    {
    }

    public ArtistdbContext(DbContextOptions<ArtistdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Albuminfo> Albuminfo { get; set; }

    public virtual DbSet<Artistinfo> Artistinfo { get; set; }

    public virtual DbSet<Trackinfo> Trackinfo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured)
        {}
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Albuminfo>(entity =>
        {
            entity.HasKey(e => e.AlbumId).HasName("PRIMARY");

            entity.ToTable("albuminfo");

            entity.HasIndex(e => e.ArtistId, "ArtistID");

            entity.Property(e => e.AlbumId)
                .ValueGeneratedNever()
                .HasColumnName("AlbumID");
            entity.Property(e => e.AlbumName).HasMaxLength(255);
            entity.Property(e => e.ArtistId).HasColumnName("ArtistID");

            entity.HasOne(d => d.Artist).WithMany(p => p.Albuminfos)
                .HasForeignKey(d => d.ArtistId)
                .HasConstraintName("albuminfo_ibfk_1");
        });

        modelBuilder.Entity<Artistinfo>(entity =>
        {
            entity.HasKey(e => e.ArtistId).HasName("PRIMARY");

            entity.ToTable("artistinfo");

            entity.Property(e => e.ArtistId)
                .ValueGeneratedNever()
                .HasColumnName("ArtistID");
            entity.Property(e => e.ArtistName).HasMaxLength(255);
            entity.Property(e => e.Description).HasColumnType("text");
        });

        modelBuilder.Entity<Trackinfo>(entity =>
        {
            entity.HasKey(e => e.TrackId).HasName("PRIMARY");

            entity.ToTable("trackinfo");

            entity.HasIndex(e => e.AlbumId, "AlbumID");

            entity.Property(e => e.TrackId)
                .ValueGeneratedNever()
                .HasColumnName("TrackID");
            entity.Property(e => e.AlbumId).HasColumnName("AlbumID");
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.Album).WithMany(p => p.Trackinfos)
                .HasForeignKey(d => d.AlbumId)
                .HasConstraintName("trackinfo_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
