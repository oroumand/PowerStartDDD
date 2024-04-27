using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;
using JobSearcher.Core.Contracts.Advertisements.Commands;
using JobSearcher.Core.Domain.Advertisements.Entities;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Update;
using JobSearcher.Core.Domain.Advertisemetns.Entities;
using JobSearcher.Core.Domain.Advertisements.Parameters;

namespace JobSearcher.Core.ApplicationService.Advertisements.Commands.Update;

public class AdvertisementUpdateHandler : CommandHandler<AdvertisementUpdateCommand>
{
    private readonly IAdvertisementCommandRepository _commandRepository;

    public AdvertisementUpdateHandler(ZaminServices zaminServices, IAdvertisementCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult> Handle(AdvertisementUpdateCommand command)
    {
        Advertisement entity = await _commandRepository.GetAsync(command.Id);

        if (entity is null)
        {
            throw new InvalidEntityStateException("VALIDATION_ERROR_NOT_EXIST", nameof(entity));
        }
        var param = _zaminServices.MapperFacade.Map<AdvertisementUpdateCommand, AdvertisementUpdateParameter>(command);
        entity.Update(param);

        await _commandRepository.CommitAsync();

        return Ok();
    }
}