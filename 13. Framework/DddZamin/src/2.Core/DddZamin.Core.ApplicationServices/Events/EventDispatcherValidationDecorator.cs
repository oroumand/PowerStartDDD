﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Extensions.Logger.Abstractions;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DddZamin.Core.ApplicationServices.Events;
public class EventDispatcherValidationDecorator : EventDispatcherDecorator
{
    #region Fields
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<EventDispatcherValidationDecorator> _logger;
    public override int Order => 1;
    #endregion

    #region Constructors
    public EventDispatcherValidationDecorator(IServiceProvider serviceProvider,
                                              ILogger<EventDispatcherValidationDecorator> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }
    #endregion

    #region Publish Domain Event
    public override async Task PublishDomainEventAsync<TDomainEvent>(TDomainEvent @event)
    {
        _logger.LogDebug(ZaminEventId.EventValidation, "Validating Event of type {EventType} With value {Event}  start at :{StartDateTime}", @event.GetType(), @event, DateTime.Now);

        List<string> errorMessages = Validate(@event);

        if (errorMessages.Any())
        {
            _logger.LogInformation(ZaminEventId.EventValidation, "Validating query of type {QueryType} With value {Query}  failed. Validation errors are: {ValidationErrors}", @event.GetType(), @event, errorMessages);
        }
        else
        {
            _logger.LogDebug(ZaminEventId.EventValidation, "Validating query of type {QueryType} With value {Query}  finished at :{EndDateTime}", @event.GetType(), @event, DateTime.Now);
            await _eventDispatcher.PublishDomainEventAsync(@event);
        }
    }
    #endregion

    #region Privaite Methods
    private List<string> Validate<TDomainEvent>(TDomainEvent @event)
    {
        List<string> errorMessages = new();

        var validator = _serviceProvider.GetService<IValidator<TDomainEvent>>();

        if (validator != null)
        {
            var validationResult = validator.Validate(@event);
            if (!validationResult.IsValid)
                errorMessages = validationResult.Errors.Select(c => c.ErrorMessage).ToList();
        }
        else
        {
            _logger.LogInformation(ZaminEventId.CommandValidation, "There is not any validator for {EventType}", @event.GetType());
        }

        return errorMessages;
    }
    #endregion
}