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
    public class ActiviteReferencee_FluentConfiguration : IEntityTypeConfiguration<ActiviteReferencee>
    {
        public void Configure(EntityTypeBuilder<ActiviteReferencee> modelBuilder)
        {
            modelBuilder
                .HasKey(ar => new { ar.EspaceId, ar.ActiviteId });

            modelBuilder
                .HasOne(a => a.Activite)
                .WithMany(b => b.ActivitesReferencees)
                .HasForeignKey(a => a.ActiviteId)
                .IsRequired();

            modelBuilder
                .HasOne(a => a.Espace)
                .WithMany(b => b.ActivitesReferencees)
                .HasForeignKey(a => a.EspaceId)
                .IsRequired();
        }
    }
}
