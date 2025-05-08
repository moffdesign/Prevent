using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
    public class PorteeEvenement_FluentConfiguration : IEntityTypeConfiguration<PorteeEvenement>
    {
        public void Configure(EntityTypeBuilder<PorteeEvenement> modelBuilder)
        {
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
