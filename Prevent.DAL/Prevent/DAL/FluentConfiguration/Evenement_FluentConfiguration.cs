using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
    internal class Evenement_FluentConfiguration : IEntityTypeConfiguration<Evenement>
    {
        public void Configure(EntityTypeBuilder<Evenement> builder)
        {
            builder.HasKey(e => e.Id);

            //builder.AsEntity<Evenement>().ToTable("Evenement");

            //builder.Property(e => e.Id)
            //    .ValueGeneratedOnAdd()
            //    .HasColumnName("ID");

            //// Fix for CS1061: Ensure the correct namespace is imported for HasColumnName
            //builder.Property(e => e.Gravite)
            //    .HasColumnName("Gravite");

            builder.Property(e => e.Criticite)
                .HasColumnName("Criticite")
                .HasColumnType("int");

            //builder.Property(e => e.DateEvenement)
            //    .HasColumnName("DateEvenement");

            //// Configure relationships if necessary
            //builder.HasMany(e => e.PorteesEvenements)
            //    .WithOne()
            //    .HasForeignKey("EvenementId");

            //builder.HasMany(e => e.Plans)
            //    .WithOne()
            //    .HasForeignKey("EvenementId");
        }
    }
}