using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
    internal class Activite_FluentConfiguration : IEntityTypeConfiguration<Activite>
    {
        public void Configure(EntityTypeBuilder<Activite> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}