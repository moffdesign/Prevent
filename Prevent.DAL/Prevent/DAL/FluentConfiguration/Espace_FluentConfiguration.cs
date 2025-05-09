using Microsoft.EntityFrameworkCore;
using Prevent.DAL.Models;

namespace Prevent.DAL.FluentConfiguration
{
    internal class Espace_FluentConfiguration : IEntityTypeConfiguration<Espace>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Espace> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}