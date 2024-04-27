using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;
using JobSearcher.Core.Contracts.Advertisements.Commands;
using JobSearcher.Core.Domain.Advertisements.Entities;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Create;
using JobSearcher.Core.Domain.Advertisemetns.Entities;
using JobSearcher.Core.Domain.Advertisements.Parameters;

namespace JobSearcher.Core.ApplicationService.Advertisements.Commands.Create;

public class AdvertisementCreateHandler : CommandHandler<AdvertisementCreateCommand, int>
{
    private readonly IAdvertisementCommandRepository _commandRepository;

    public AdvertisementCreateHandler(ZaminServices zaminServices, IAdvertisementCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult<int>> Handle(AdvertisementCreateCommand command)
    {
        var parameter = _zaminServices.MapperFacade.Map<AdvertisementCreateCommand, AdvertisementCreateParameter>(command);
        Advertisement entity = new(parameter);

        await _commandRepository.InsertAsync(entity);

        await _commandRepository.CommitAsync();

        return await OkAsync(entity.Id);
    }
}