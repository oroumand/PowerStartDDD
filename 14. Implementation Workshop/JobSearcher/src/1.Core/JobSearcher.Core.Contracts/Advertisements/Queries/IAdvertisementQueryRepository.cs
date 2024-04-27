using Zamin.Core.RequestResponse.Queries;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetById;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetPagedFilter;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetSelectList;

namespace JobSearcher.Core.Contracts.Advertisements.Queries;

public interface IAdvertisementQueryRepository
{
    Task<AdvertisementQr?> ExecuteAsync(AdvertisementGetByIdQuery query);

    Task<List<AdvertisementSelectItemQr>> ExecuteAsync(AdvertisementGetSelectListQuery query);

    Task<PagedData<AdvertisementListItemQr>> ExecuteAsync(AdvertisementGetPagedFilterQuery query);
}