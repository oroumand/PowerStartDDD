using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;
using JobSearcher.Core.Contracts.Advertisements.Queries;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetSelectList;

namespace JobSearcher.Core.ApplicationService.Advertisements.Queries.GetSelectList;

public sealed class AdvertisementGetSelectListHandler : QueryHandler<AdvertisementGetSelectListQuery, List<AdvertisementSelectItemQr>>
{
    private readonly IAdvertisementQueryRepository _queryRepository;

    public AdvertisementGetSelectListHandler(ZaminServices zaminServices, IAdvertisementQueryRepository queryRepository) 
        : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<List<AdvertisementSelectItemQr>>> Handle(AdvertisementGetSelectListQuery query)
    {
        return Result(await _queryRepository.ExecuteAsync(query));
    }
}