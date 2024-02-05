using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SkolaDB_Database_Labb3.Models;

namespace SkolaDB_Database_Labb3.Data;

public partial class SkolaDbContext : DbContext
{
    public SkolaDbContext()
    {
    }

    public SkolaDbContext(DbContextOptions<SkolaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Betyg> Betygs { get; set; }

    public virtual DbSet<Klasser> Klassers { get; set; }

    public virtual DbSet<Kurser> Kursers { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<Studenter> Studenters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-1IK4QMP;Initial Catalog=SkolaDB;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Betyg>(entity =>
        {
            entity.HasKey(e => e.BetygId).HasName("PK__Betyg__E90ED048360945FB");

            entity.ToTable("Betyg");

            entity.Property(e => e.BetygId).HasColumnName("BetygID");
            entity.Property(e => e.Betyg1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Betyg");
            entity.Property(e => e.KursId).HasColumnName("KursID");
            entity.Property(e => e.LarareId).HasColumnName("LarareID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Kurs).WithMany(p => p.Betygs)
                .HasForeignKey(d => d.KursId)
                .HasConstraintName("FK__Betyg__KursID__4E88ABD4");

            entity.HasOne(d => d.Larare).WithMany(p => p.Betygs)
                .HasForeignKey(d => d.LarareId)
                .HasConstraintName("FK__Betyg__LarareID__4F7CD00D");

            entity.HasOne(d => d.Student).WithMany(p => p.Betygs)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Betyg__StudentID__4D94879B");
        });

        modelBuilder.Entity<Klasser>(entity =>
        {
            entity.HasKey(e => e.KlassId).HasName("PK__Klasser__CF47A60D8652CDCA");

            entity.ToTable("Klasser");

            entity.Property(e => e.KlassId).HasColumnName("KlassID");
            entity.Property(e => e.KlassN)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LärareId).HasColumnName("LärareID");

            entity.HasOne(d => d.Lärare).WithMany(p => p.Klassers)
                .HasForeignKey(d => d.LärareId)
                .HasConstraintName("FK__Klasser__LärareI__44FF419A");
        });

        modelBuilder.Entity<Kurser>(entity =>
        {
            entity.HasKey(e => e.KursId).HasName("PK__Kurser__BCCFFF3B7659B45F");

            entity.ToTable("Kurser");

            entity.Property(e => e.KursId).HasColumnName("KursID");
            entity.Property(e => e.KursN)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LärareId).HasColumnName("LärareID");

            entity.HasOne(d => d.Lärare).WithMany(p => p.Kursers)
                .HasForeignKey(d => d.LärareId)
                .HasConstraintName("FK__Kurser__LärareID__4AB81AF0");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personal__3214EC274F9F7991");

            entity.ToTable("Personal");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Namn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PN");
            entity.Property(e => e.Tjänst)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Studenter>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Studente__32C52A791C878E2B");

            entity.ToTable("Studenter");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("First Name");
            entity.Property(e => e.KlassId).HasColumnName("KlassID");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Last Name");
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PN");

            entity.HasOne(d => d.Klass).WithMany(p => p.Studenters)
                .HasForeignKey(d => d.KlassId)
                .HasConstraintName("FK__Studenter__Klass__47DBAE45");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
