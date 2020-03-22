using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProject
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {

        }
        public virtual DbSet<AppUsers> AppUsers { get; set; }
        public virtual DbSet<Highscores> Highscores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog= Project; Persist Security Info = True; User ID = SA; Password = Passw0rd2018");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__AppUsers__1788CCACC91CBBC7");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Highscores>(entity =>
            {
                entity.HasKey(e => e.HighscoreId)
                    .HasName("PK__Highscor__AAB07C6EA36AF6E6");

                entity.Property(e => e.HighscoreId)
                    .HasColumnName("HighscoreID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
