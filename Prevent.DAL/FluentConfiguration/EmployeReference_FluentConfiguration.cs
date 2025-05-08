using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
	public class EmployeReference_FluentConfiguration : IEntityTypeConfiguration<EmployeReference>
    {
		public void Configure(EntityTypeBuilder<EmployeReference> modelBuilder)
		{
			modelBuilder
				.HasKey(ar => new { ar.EspaceId, ar.EmployeId });

			modelBuilder
				.HasOne(a => a.Employe)
				.WithMany(b => b.EmployesReferences)
				.HasForeignKey(a => a.EmployeId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Espace)
				.WithMany(b => b.EmployesReferences)
				.HasForeignKey(a => a.EspaceId)
				.IsRequired();
		}
	}
}
