﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
	public class RisqueReference_FluentConfiguration : IEntityTypeConfiguration<RisqueReference>
    {
		public void Configure(EntityTypeBuilder<RisqueReference> modelBuilder)
		{
            modelBuilder.ToTable("RisqueReference", "Prevention");

			modelBuilder
				.Property(a => a.RisqueId)
                .HasColumnName("RisqueId")
                .IsRequired();

            modelBuilder.Property(a => a.EspaceId)
                .HasColumnName("EspaceId")
                .IsRequired();

            modelBuilder
				.HasKey(ar => new { ar.EspaceId, ar.RisqueId });

			modelBuilder
				.HasOne(a => a.Risque)
				.WithMany(b => b.RisquesReferences)
				.HasForeignKey(a => a.RisqueId)
				.IsRequired();

			modelBuilder
				.HasOne(a => a.Espace)
				.WithMany(b => b.RisquesReferences)
				.HasForeignKey(a => a.EspaceId)
				.IsRequired();
		}
	}
}
