using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.FluentConfiguration
{
    public class PorteeAudit_FluentConfiguration : IEntityTypeConfiguration<PorteeAudit>
	{
        public void Configure(EntityTypeBuilder<PorteeAudit> modelBuilder)
        {
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
