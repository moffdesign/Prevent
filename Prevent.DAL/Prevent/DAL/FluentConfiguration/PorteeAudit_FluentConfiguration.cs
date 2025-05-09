using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
    public class PorteeAudit_FluentConfiguration : IEntityTypeConfiguration<PorteeAudit>
	{
        public void Configure(EntityTypeBuilder<PorteeAudit> modelBuilder)
        {
            modelBuilder.ToTable("PorteeAudit", "Prevention");
            
            modelBuilder
                .Property(a => a.AuditId)
                .HasColumnName("AuditId")
                .IsRequired();
            
            modelBuilder
                .Property(a => a.EspaceId)
                .HasColumnName("EspaceId")
                .IsRequired();

            modelBuilder
                .HasKey(ar => new { ar.EspaceId, ar.AuditId });

            modelBuilder
                .HasOne(a => a.Audit)
                .WithMany(b => b.PorteesAudits)
                .HasForeignKey(a => a.AuditId)
                .IsRequired();

            modelBuilder
                .HasOne(a => a.Espace)
                .WithMany(b => b.PorteesAudits)
                .HasForeignKey(a => a.EspaceId)
                .IsRequired();
        }
    }
}
