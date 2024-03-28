using DddZamin.Core.Domain.Exceptions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Extensions.Logger.Abstractions;

namespace DddZamin.Core.ApplicationServices.Events;
    internal class EventDispatcherDomainExceptionHandlerDecorator : EventDispatcherDecorator
{
    #region Fields
    private readonly ILogger<EventDispatcherDomainExceptionHandlerDecorator> _logger;
    public override int Order => 2;
    #endregion

    #region Constructors
    public EventDispatcherDomainExceptionHandlerDecorator(ILogger<EventDispatcherDomainExceptionHandlerDecorator> logger)
    {
        _logger = logger;
    }
    #endregion

    #region Publish Domain Event
    public override async Task PublishDomainEventAsync<TDomainEvent>(TDomainEvent @event)
    {
        try
        {
            await _eventDispatcher.PublishDomainEventAsync(@event);
        }
        catch (DomainStateException ex)
        {
            _logger.LogError(ZaminEventId.DomainValidationException, ex, "Processing of {EventType} With value {Event} failed at {StartDateTime} because there are domain exceptions.", @event.GetType(), @event, DateTime.Now);
        }
        catch (AggregateException ex)
        {
            if (ex.InnerException is DomainStateException domainStateException)
            {
                _logger.LogError(ZaminEventId.DomainValidationException, ex, "Processing of {EventType} With value {Event} failed at {StartDateTime} because there are domain exceptions.", @event.GetType(), @event, DateTime.Now);
            }
            throw ex;
        }
    }
    #endregion
}
