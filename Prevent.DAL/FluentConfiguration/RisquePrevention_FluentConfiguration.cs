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
	public class RisquePrevention_FluentConfiguration
	{
		public void Configure(EntityTypeBuilder<RisquePrevention> modelBuilder)
		{
			modelBuilder
				.HasKey(ar => new { ar.PreventionId, ar.RisqueId });

			modelBuilder
				.HasOne(a => a.Risque)
				.WithMany(b => b.RisquePreventions)
				.HasForeignKey(a => a.RisqueId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Prevention)
				.WithMany(b => b.RisquePreventions)
				.HasForeignKey(a => a.PreventionId)
				.IsRequired();
		}
	}
}
