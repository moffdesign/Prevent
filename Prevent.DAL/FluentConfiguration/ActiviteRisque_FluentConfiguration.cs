using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prevent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Prevent.DAL.FluentConfiguration
{
	public class ActiviteRisque_FluentConfiguration : IEntityTypeConfiguration<ActiviteRisque>
	{
		public void Configure(EntityTypeBuilder<ActiviteRisque> modelBuilder)
		{
			modelBuilder
				.HasKey(ar => new { ar.ActiviteId, ar.RisqueId });

			modelBuilder
				.HasOne(a => a.Risque)
				.WithMany(b => b.ActiviteRisques)
				.HasForeignKey(a => a.RisqueId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Activite)
				.WithMany(b => b.ActiviteRisques)
				.HasForeignKey(a => a.ActiviteId)
				.IsRequired();
		}
	}
}
