using DddZamin.Infra.Data.Sql.Queries;
using Microsoft.EntityFrameworkCore;

namespace MiniBlog.Infra.Data.Sql.Queries
{
    public class MiniblogQueryDbContext : BaseQueryDbContext
    {
        public MiniblogQueryDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
