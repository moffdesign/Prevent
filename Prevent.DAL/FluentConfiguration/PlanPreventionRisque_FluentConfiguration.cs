using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prevent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.FluentConfiguration
{
	public class PlanPreventionRisque_FluentConfiguration
	{
		public void Configure(EntityTypeBuilder<PlanVigilanceRisque> modelBuilder)
		{
			modelBuilder
				.HasKey(ar => new { ar.PlanPreventionId, ar.RisqueId });

			modelBuilder
				.HasOne(a => a.Risque)
				.WithMany(b => b.PlanPreventionRisques)
				.HasForeignKey(a => a.RisqueId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.PlanPrevention)
				.WithMany(b => b.PlanPreventionRisques)
				.HasForeignKey(a => a.PlanPreventionId)
				.IsRequired();
		}
	}
}
