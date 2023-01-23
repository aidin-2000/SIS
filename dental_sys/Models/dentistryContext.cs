using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dental_sys.Models
{
    public partial class dentistryContext : DbContext
    {
        public dentistryContext()
        {
        }

        public dentistryContext(DbContextOptions<dentistryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppointmentDoctor> AppointmentDoctor { get; set; }
        public virtual DbSet<Directory> Directory { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<TableClient> TableClient { get; set; }
        public virtual DbSet<TableDiagnosis> TableDiagnosis { get; set; }
        public virtual DbSet<TableDoctor> TableDoctor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ASKERBEKOV;Database=dentistry;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentDoctor>(entity =>
            {
                entity.ToTable("Appointment_Doctor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Дата).HasColumnType("datetime");

                entity.Property(e => e.ЛечВрач).HasColumnName("Леч_врач");

                entity.Property(e => e.Фио).HasColumnName("ФИО");

                entity.Property(e => e.ЦенаЗаУслугу).HasColumnName("Цена_за_услугу");

                entity.HasOne(d => d.ДиагнозNavigation)
                    .WithMany(p => p.AppointmentDoctor)
                    .HasForeignKey(d => d.Диагноз)
                    .HasConstraintName("FK_Appointment_Doctor_Table_diagnosis");

                entity.HasOne(d => d.ЛечВрачNavigation)
                    .WithMany(p => p.AppointmentDoctor)
                    .HasForeignKey(d => d.ЛечВрач)
                    .HasConstraintName("FK_Appointment_Doctor_Table_doctor");

                entity.HasOne(d => d.ФиоNavigation)
                    .WithMany(p => p.AppointmentDoctor)
                    .HasForeignKey(d => d.Фио)
                    .HasConstraintName("FK_Appointment_Doctor_Table_client");
            });

            modelBuilder.Entity<Directory>(entity =>
            {
                entity.ToTable("directory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Position1)
                    .HasColumnName("Position")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableClient>(entity =>
            {
                entity.ToTable("Table_client");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableDiagnosis>(entity =>
            {
                entity.ToTable("Table_diagnosis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Диагноз)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableDoctor>(entity =>
            {
                entity.ToTable("Table_doctor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("image");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Адрес)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Номер)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PositionNavigation)
                    .WithMany(p => p.TableDoctor)
                    .HasForeignKey(d => d.Position)
                    .HasConstraintName("FK_Table_doctor_Position");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
