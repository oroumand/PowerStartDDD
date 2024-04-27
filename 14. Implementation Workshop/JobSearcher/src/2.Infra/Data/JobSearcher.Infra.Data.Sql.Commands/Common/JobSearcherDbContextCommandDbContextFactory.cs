using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace JobSearcher.Infra.Data.Sql.Commands.Common;

public class JobSearcherDbContextCommandDbContextFactory : IDesignTimeDbContextFactory<JobSearcherDbContextCommandDbContext>
{
    public JobSearcherDbContextCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<JobSearcherDbContextCommandDbContext>();

        builder.UseSqlServer("Server =.; Database=JobSearcherDbContextDb;User Id = sa;Password=1qaz!QAZ; MultipleActiveResultSets=true; Encrypt = false");

        return new JobSearcherDbContextCommandDbContext(builder.Options);
    }
}