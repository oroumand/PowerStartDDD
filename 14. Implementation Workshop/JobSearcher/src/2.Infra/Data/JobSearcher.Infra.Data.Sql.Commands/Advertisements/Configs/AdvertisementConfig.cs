using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobSearcher.Core.Domain.Advertisemetns.Entities;

namespace JobSearcher.Infra.Data.Sql.Commands.Advertisements.Configs;

public sealed class AdvertisementConfig : IEntityTypeConfiguration<Advertisement>
{
    public void Configure(EntityTypeBuilder<Advertisement> builder)
    {
        builder.Property(c => c.BusinessId).IsRequired();
        builder.HasIndex(c => c.BusinessId).IsUnique();
        builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Description).IsRequired().HasMaxLength(1000);
    }
}
