using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
	public class PreventionRisque_FluentConfiguration : IEntityTypeConfiguration<PreventionRisque>
    {
		public void Configure(EntityTypeBuilder<PreventionRisque> modelBuilder)
		{
            modelBuilder.ToTable("PreventionRisque", "Prevention");

			modelBuilder
				.Property(a => a.PreventionId)
                .HasColumnName("PreventionId")
                .IsRequired();

			modelBuilder
				.Property(a => a.RisqueId)
                .HasColumnName("RisqueId")
                .IsRequired();

            modelBuilder
				.HasKey(ar => new { ar.PreventionId, ar.RisqueId });

			modelBuilder
				.HasOne(a => a.Risque)
				.WithMany(b => b.PreventionsRisques)
				.HasForeignKey(a => a.RisqueId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Prevention)
				.WithMany(b => b.PreventionsRisques)
				.HasForeignKey(a => a.PreventionId)
				.IsRequired();
		}
	}
}
