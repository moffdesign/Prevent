using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
	public class ActiviteRisque_FluentConfiguration : IEntityTypeConfiguration<ActiviteRisque>
	{
		public void Configure(EntityTypeBuilder<ActiviteRisque> modelBuilder)
		{
            modelBuilder.ToTable("ActiviteRisque", "Prevention");

			modelBuilder
				.Property(a => a.ActiviteId)
                .HasColumnName("ActiviteId")
                .IsRequired();

			modelBuilder
				.Property(a => a.RisqueId)
                .HasColumnName("RisqueId")
                .IsRequired();

            modelBuilder
				.HasKey(ar => new { ar.ActiviteId, ar.RisqueId });

			modelBuilder
				.HasOne(a => a.Risque)
				.WithMany(b => b.ActivitesRisques)
				.HasForeignKey(a => a.RisqueId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Activite)
				.WithMany(b => b.ActivitesRisques)
				.HasForeignKey(a => a.ActiviteId)
				.IsRequired();
		}
	}
}
