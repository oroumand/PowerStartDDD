using DddZamin.Core.Domain.Events;

namespace DddZamin.Core.Domain.Entities;
public interface IAggregateRoot
{
    void ClearEvents();
    IEnumerable<IDomainEvent> GetEvents();
}
