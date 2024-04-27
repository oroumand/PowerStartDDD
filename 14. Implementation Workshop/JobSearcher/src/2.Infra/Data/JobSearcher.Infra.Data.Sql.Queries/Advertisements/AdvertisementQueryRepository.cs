using Microsoft.EntityFrameworkCore;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Infra.Data.Sql.Queries;
using JobSearcher.Core.Contracts.Advertisements.Queries;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetById;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetPagedFilter;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetSelectList;
using JobSearcher.Infra.Data.Sql.Queries.Common;
using JobSearcher.Infra.Data.Sql.Queries.Advertisements.Entities;

namespace JobSearcher.Infra.Data.Sql.Queries.Advertisements;

public class AdvertisementQueryRepository : BaseQueryRepository<JobSearcherDbContextQueryDbContext>, IAdvertisementQueryRepository
{
    public AdvertisementQueryRepository(JobSearcherDbContextQueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<AdvertisementQr?> ExecuteAsync(AdvertisementGetByIdQuery query)
    {
        return await _dbContext.Set<Advertisement>()
            .Where(Advertisement => Advertisement.Id == query.Id)
            .Select(Advertisement => (AdvertisementQr)Advertisement)
            .FirstOrDefaultAsync();
    }

    public async Task<List<AdvertisementSelectItemQr>> ExecuteAsync(AdvertisementGetSelectListQuery query)
    {
        return await _dbContext.Set<Advertisement>().Select(Advertisement => (AdvertisementSelectItemQr)Advertisement).ToListAsync();
    }

    public async Task<PagedData<AdvertisementListItemQr>> ExecuteAsync(AdvertisementGetPagedFilterQuery query)
    {
        var filter = _dbContext.Set<Advertisement>().AsQueryable();

        return await filter.ToPagedData(query, Advertisement => (AdvertisementListItemQr)Advertisement);
    }
}