using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
    public class PorteeEvenement_FluentConfiguration : IEntityTypeConfiguration<PorteeEvenement>
    {
        public void Configure(EntityTypeBuilder<PorteeEvenement> modelBuilder)
        {
            modelBuilder.ToTable("PorteeEvenement", "Prevention");

            modelBuilder
                .Property(a => a.EvenementId)
                .HasColumnName("EvenementId")
                .IsRequired();

            modelBuilder
                .Property(a => a.EspaceId)
                .HasColumnName("EspaceId")
                .IsRequired();

            modelBuilder
                .HasKey(ar => new { ar.EspaceId, ar.EvenementId });

            modelBuilder
                .HasOne(a => a.Evenement)
                .WithMany(b => b.PorteesEvenements)
                .HasForeignKey(a => a.EvenementId)
                .IsRequired();

            modelBuilder
                .HasOne(a => a.Espace)
                .WithMany(b => b.PorteesEvenements)
                .HasForeignKey(a => a.EspaceId)
                .IsRequired();
        }
    }
}
