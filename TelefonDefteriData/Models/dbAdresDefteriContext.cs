using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TelefonDefteriData.Models
{
    public partial class dbAdresDefteriContext : DbContext
    {
        public dbAdresDefteriContext()
        {
        }

        public dbAdresDefteriContext(DbContextOptions<dbAdresDefteriContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CallLog> CallLogs { get; set; }
        public virtual DbSet<PhoneList> PhoneLists { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=dbAdresDefteri;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<CallLog>(entity =>
            {
                entity.HasKey(e => e.CallId)
                    .HasName("PK_CallHistory");

                entity.ToTable("CallLog");

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.CallLast).HasColumnType("date");

                entity.Property(e => e.CallNext).HasColumnType("date");

                entity.Property(e => e.CalledLastName).HasMaxLength(50);

                entity.Property(e => e.CalledName).HasMaxLength(50);

                entity.Property(e => e.CalledPhone).HasMaxLength(50);

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CallLogs)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("FK_CallLog_PhoneList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CallLogs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CallLog_Users");
            });

            modelBuilder.Entity<PhoneList>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("PhoneList");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMail");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhoneLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PhoneList_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMail");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
