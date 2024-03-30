using DddZamin.Infra.Data.Sql.Commands;
using MiniBlog.Core.Contracts.People.Commands;
using MiniBlog.Core.Domain.People.Entities;

namespace MiniBlog.Infra.Data.Sql.Commands.People
{
    public class PersonCommandRepository : BaseCommandRepository<Person, MiniblogDbContext, int>, IPersonCommandRepository
    {
        public PersonCommandRepository(MiniblogDbContext dbContext) : base(dbContext)
        {
        }
    }
}
