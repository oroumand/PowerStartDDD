using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;
using JobSearcher.Core.Contracts.Advertisements.Commands;
using JobSearcher.Core.Domain.Advertisements.Entities;
using JobSearcher.Core.Domain.Advertisemetns.Entities;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Publishe;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.UnPublishe;

namespace JobSearcher.Core.ApplicationService.Advertisements.Commands.Publish;

public class AdvertisementUnPublishHandler : CommandHandler<AdvertisementUnPublisheCommand>
{
    private readonly IAdvertisementCommandRepository _commandRepository;

    public AdvertisementUnPublishHandler(ZaminServices zaminServices, IAdvertisementCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult> Handle(AdvertisementUnPublisheCommand command)
    {
        Advertisement entity = await _commandRepository.GetAsync(command.Id);

        if (entity is null)
        {
            throw new InvalidEntityStateException("VALIDATION_ERROR_NOT_EXIST", nameof(entity));
        }

        entity.Publish();

        await _commandRepository.CommitAsync();

        return Ok();
    }
}