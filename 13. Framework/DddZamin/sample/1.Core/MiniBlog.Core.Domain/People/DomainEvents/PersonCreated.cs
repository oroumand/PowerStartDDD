using DddZamin.Core.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Core.Domain.People.DomainEvents
{
    public record PersonCreated(int Id, Guid BusinessId, string FirstName, string LastName) : IDomainEvent;

}
