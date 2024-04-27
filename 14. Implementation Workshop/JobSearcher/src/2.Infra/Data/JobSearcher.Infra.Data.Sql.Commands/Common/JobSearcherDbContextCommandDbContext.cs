using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace JobSearcher.Infra.Data.Sql.Commands.Common;

public class JobSearcherDbContextCommandDbContext : BaseOutboxCommandDbContext
{
    public JobSearcherDbContextCommandDbContext(DbContextOptions<JobSearcherDbContextCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}