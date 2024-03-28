using DddZamin.Core.Domain.Events;

namespace DddZamin.Core.Contracts.ApplicationServices.Events;
public interface IDomainEventHandler<TDomainEvent> where TDomainEvent : IDomainEvent
{
    Task Handle(TDomainEvent Event);
}