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
    public class PorteePlan_FluentConfiguration : IEntityTypeConfiguration<PorteePlan>
    {
        public void Configure(EntityTypeBuilder<PorteePlan> modelBuilder)
        {
            modelBuilder
                .HasKey(ar => new { ar.EspaceId, ar.PlanId });

            modelBuilder
                .HasOne(a => a.Plan)
                .WithMany(b => b.PorteesPlans)
                .HasForeignKey(a => a.PlanId)
                .IsRequired();

            modelBuilder
                .HasOne(a => a.Espace)
                .WithMany(b => b.PorteesPlans)
                .HasForeignKey(a => a.EspaceId)
                .IsRequired();
        }
    }
}
