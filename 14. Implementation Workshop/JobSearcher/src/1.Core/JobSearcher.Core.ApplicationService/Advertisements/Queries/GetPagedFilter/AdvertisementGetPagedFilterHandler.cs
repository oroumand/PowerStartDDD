using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;
using JobSearcher.Core.Contracts.Advertisements.Queries;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetPagedFilter;

namespace JobSearcher.Core.ApplicationService.Advertisements.Queries.GetPagedFilter;

public sealed class AdvertisementGetPagedFilterHandler : QueryHandler<AdvertisementGetPagedFilterQuery, PagedData<AdvertisementListItemQr>>
{
    private readonly IAdvertisementQueryRepository _queryRepository;

    public AdvertisementGetPagedFilterHandler(ZaminServices zaminServices, IAdvertisementQueryRepository queryRepository) 
        : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<PagedData<AdvertisementListItemQr>>> Handle(AdvertisementGetPagedFilterQuery query)
    {
        return Result(await _queryRepository.ExecuteAsync(query));
    }
}