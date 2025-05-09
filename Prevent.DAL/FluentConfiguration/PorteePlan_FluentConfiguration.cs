using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
    public class PorteePlan_FluentConfiguration : IEntityTypeConfiguration<PorteePlan>
    {
        public void Configure(EntityTypeBuilder<PorteePlan> modelBuilder)
        {
            modelBuilder.ToTable("PorteePlan", "Prevention");
            
            modelBuilder
                .Property(a => a.PlanId)
                .HasColumnName("PlanId")
                .IsRequired();

            modelBuilder
                .Property(a => a.EspaceId)
                .HasColumnName("EspaceId")
                .IsRequired();

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
