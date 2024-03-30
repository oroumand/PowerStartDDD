using DddZamin.Infra.Data.Sql.Queries;
using MiniBlog.Core.Contracts.People.Queries;

namespace MiniBlog.Infra.Data.Sql.Queries.People
{
    public class PersonQueryRepository : BaseQueryRepository<MiniblogQueryDbContext>, IPersonQueryRepository
    {
        public PersonQueryRepository(MiniblogQueryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
