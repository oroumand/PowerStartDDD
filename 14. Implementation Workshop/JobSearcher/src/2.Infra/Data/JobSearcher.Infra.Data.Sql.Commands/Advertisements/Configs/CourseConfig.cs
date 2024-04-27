using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobSearcher.Core.Domain.Advertisements.Entities;

namespace JobSearcher.Infra.Data.Sql.Commands.Advertisements.Configs;

public sealed class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(c => c.BusinessId).IsRequired();
        builder.HasIndex(c => c.BusinessId).IsUnique();
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
    }
}