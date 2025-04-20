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
    public class Espace_FluentConfiguration : IEntityTypeConfiguration<Espace>
	{
		public void Configure(EntityTypeBuilder<Espace> modelBuilder)
		{
			modelBuilder
				.HasMany<Activite>(b => b.Activites);
				//.WithOne(b => b.Brand)
				//.HasForeignKey(b => b.BrandId)
				//.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
