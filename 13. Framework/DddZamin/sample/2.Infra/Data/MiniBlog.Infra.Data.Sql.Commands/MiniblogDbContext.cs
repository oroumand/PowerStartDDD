using DddZamin.Infra.Data.Sql.Commands;
using DddZamin.Infra.Data.Sql.Commands.ValueConversions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.Domain.People.ValueObjects;

namespace MiniBlog.Infra.Data.Sql.Commands
{
    public class MiniblogDbContext : BaseCommandDbContext
    {
        public MiniblogDbContext(DbContextOptions<MiniblogDbContext> options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<FirstName>().HaveConversion<FirstNameConversion>();
            configurationBuilder.Properties<LastName>().HaveConversion<LastNameConversion>();
        }
        public DbSet<Person> People { get; set; }
    }

    public class BloggingContextFactory : IDesignTimeDbContextFactory<MiniblogDbContext>
    {
        public MiniblogDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MiniblogDbContext>();
            optionsBuilder.UseSqlServer("Server =.; Database=MiniBlogDb;User Id = sa;Password=1qaz!QAZ; MultipleActiveResultSets=true; Encrypt = false");

            return new MiniblogDbContext(optionsBuilder.Options);
        }
    }
}
