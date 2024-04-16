using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LocaLux_GestActivite.Models
{
    public partial class LocaluxContext : DbContext
    {
        public LocaluxContext()
        {
        }

        public LocaluxContext(DbContextOptions<LocaluxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AncienMdp> AncienMdps { get; set; } = null!;
        public virtual DbSet<Chauffeur> Chauffeurs { get; set; } = null!;
        public virtual DbSet<Controle> Controles { get; set; } = null!;
        public virtual DbSet<Destination> Destinations { get; set; } = null!;
        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<Forfait> Forfaits { get; set; } = null!;
        public virtual DbSet<MessengerMessage> MessengerMessages { get; set; } = null!;
        public virtual DbSet<Modele> Modeles { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
        public virtual DbSet<Voiture> Voitures { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.54.40;port=3306;user=admin-localux;password=P@ssw0rd;database=Localux;charset=utf8", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.6-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<AncienMdp>(entity =>
            {
                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.AncienMdps)
                    .HasForeignKey(d => d.UtilisateurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F58A3CBDFB88E14F");
            });

            modelBuilder.Entity<Controle>(entity =>
            {
                entity.HasOne(d => d.EmployeVerif)
                    .WithMany(p => p.Controles)
                    .HasForeignKey(d => d.EmployeVerifId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_E39396ECC0DD409");
            });

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<MessengerMessage>(entity =>
            {
                entity.Property(e => e.AvailableAt).HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.CreatedAt).HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.DeliveredAt).HasComment("(DC2Type:datetime_immutable)");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasOne(d => d.DestinationArriver)
                    .WithMany(p => p.ReservationDestinationArrivers)
                    .HasForeignKey(d => d.DestinationArriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_42C849557A078AD6");

                entity.HasOne(d => d.DestinationDepart)
                    .WithMany(p => p.ReservationDestinationDeparts)
                    .HasForeignKey(d => d.DestinationDepartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_42C84955FF824EB1");

                entity.HasOne(d => d.LaVoiture)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.LaVoitureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_42C849552187EC6E");

                entity.HasOne(d => d.LeChauffeur)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.LeChauffeurId)
                    .HasConstraintName("FK_42C849558899931");

                entity.HasOne(d => d.LeClient)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.LeClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_42C84955C0F37DD6");

                entity.HasOne(d => d.LeControle)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.LeControleId)
                    .HasConstraintName("FK_42C8495534AE5CB9");

                entity.HasOne(d => d.LeForfait)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.LeForfaitId)
                    .HasConstraintName("FK_42C84955B36D2087");
            });

            modelBuilder.Entity<Voiture>(entity =>
            {
                entity.HasOne(d => d.LeModele)
                    .WithMany(p => p.Voitures)
                    .HasForeignKey(d => d.LeModeleId)
                    .HasConstraintName("FK_E9E2810F750CA3FD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
