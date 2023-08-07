using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project_PRN211.Models
{
    public partial class projectPRN211Context : DbContext
    {
        public projectPRN211Context()
        {
        }

        public projectPRN211Context(DbContextOptions<projectPRN211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<ChiTieu> ChiTieus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-EUMEG71\\MSSQLSERVER03;database=projectPRN211;Trusted_Connection =SSPI;Encrypt=false;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ChiTieu>(entity =>
            {
                entity.ToTable("ChiTieu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Chude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chude");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("money");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("noidung");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ChiTieus)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__ChiTieu__userid__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
