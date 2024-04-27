using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace JobSearcher.Infra.Data.Sql.Queries.Common;

public class JobSearcherDbContextQueryDbContext : BaseQueryDbContext
{
    public JobSearcherDbContextQueryDbContext(DbContextOptions<JobSearcherDbContextQueryDbContext> options) : base(options)
    {
    }
}