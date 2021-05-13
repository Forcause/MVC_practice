using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication.Models
{
    public partial class pract7Context : DbContext
    {
        public pract7Context()
        {
        }

        public pract7Context(DbContextOptions<pract7Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Corps> Corps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=pract7;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Auto>(entity =>
            {
                entity.ToTable("AUTOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BodyType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Body_Type");

                entity.Property(e => e.Mark)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.MarkNavigation)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.Mark)
                    .HasConstraintName("FK_AUTO_ToCORP");
            });

            modelBuilder.Entity<Corps>(entity =>
            {
                entity.HasKey(e => e.Mark)
                    .HasName("PK__CORPS__2724EBFAF3C6F0E7");

                entity.ToTable("CORPS");

                entity.Property(e => e.Mark)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.President)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Production)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
