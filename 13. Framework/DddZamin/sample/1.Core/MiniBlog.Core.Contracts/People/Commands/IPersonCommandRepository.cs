using DddZamin.Core.Contracts.Data.Commands;
using MiniBlog.Core.Domain.People.Entities;

namespace MiniBlog.Core.Contracts.People.Commands
{
    public interface IPersonCommandRepository:ICommandRepository<Person,int>
    {
    }
}
