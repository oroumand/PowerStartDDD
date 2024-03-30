using DddZamin.Infra.Data.Sql.Commands;
using DddZamin.Infra.Data.Sql.Commands.ValueConversions;
using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.Domain.People.ValueObjects;

namespace MiniBlog.Infra.Data.Sql.Commands
{
    public class MiniblogDbContext : BaseCommandDbContext
    {
        public MiniblogDbContext(DbContextOptions options) : base(options)
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
}
