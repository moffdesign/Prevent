using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.FluentConfiguration
{
	public class EspacePrevention_FluentConfiguration
	{
		public void Configure(EntityTypeBuilder<PreventionReferencee> modelBuilder)
		{
			modelBuilder
				.HasKey(ar => new { ar.EspaceId, ar.PreventionId });

			modelBuilder
				.HasOne(a => a.Prevention)
				.WithMany(b => b.EspacePreventions)
				.HasForeignKey(a => a.PreventionId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Espace)
				.WithMany(b => b.EspacePreventions)
				.HasForeignKey(a => a.EspaceId)
				.IsRequired();
		}
	}
}
