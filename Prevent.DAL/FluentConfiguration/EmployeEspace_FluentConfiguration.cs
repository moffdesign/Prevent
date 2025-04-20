using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.FluentConfiguration
{
	public class EmployeEspace_FluentConfiguration
	{
		public void Configure(EntityTypeBuilder<EmployeEspace> modelBuilder)
		{
			modelBuilder
				.HasKey(ar => new { ar.EspaceId, ar.EmployeId });

			modelBuilder
				.HasOne(a => a.Employe)
				.WithMany(b => b.EmployeEspaces)
				.HasForeignKey(a => a.EmployeId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Espace)
				.WithMany(b => b.EmployeEspaces)
				.HasForeignKey(a => a.EspaceId)
				.IsRequired();
		}
	}
}
