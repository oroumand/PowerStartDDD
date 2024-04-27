﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobSearcher.Infra.Data.Sql.Queries.Advertisements.Entities;

namespace JobSearcher.Infra.Data.Sql.Queries.Advertisements.Configs;

public sealed class AdvertisementConfig : IEntityTypeConfiguration<Advertisement>
{
    public void Configure(EntityTypeBuilder<Advertisement> builder)
    {
        builder.Property(c => c.BusinessId).IsRequired();
        builder.HasIndex(c => c.BusinessId).IsUnique();
    }
}