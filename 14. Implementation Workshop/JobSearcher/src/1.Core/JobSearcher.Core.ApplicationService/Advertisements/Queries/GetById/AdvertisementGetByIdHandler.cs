using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;
using JobSearcher.Core.Contracts.Advertisements.Queries;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetById;

namespace JobSearcher.Core.ApplicationService.Advertisements.Queries.GetById;

public sealed class AdvertisementGetByIdHandler : QueryHandler<AdvertisementGetByIdQuery, AdvertisementQr?>
{
    private readonly IAdvertisementQueryRepository _queryRepository;

    public AdvertisementGetByIdHandler(ZaminServices zaminServices, IAdvertisementQueryRepository queryRepository) 
        : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<AdvertisementQr?>> Handle(AdvertisementGetByIdQuery query)
    {
        return Result(await _queryRepository.ExecuteAsync(query));
    }
}