using Zamin.Infra.Data.Sql.Commands;
using JobSearcher.Core.Contracts.Advertisements.Commands;
using JobSearcher.Core.Domain.Advertisements.Entities;
using JobSearcher.Infra.Data.Sql.Commands.Common;
using JobSearcher.Core.Domain.Advertisemetns.Entities;

namespace JobSearcher.Infra.Data.Sql.Commands.Advertisements;

public sealed class AdvertisementCommandRepository
    : BaseCommandRepository<Advertisement, JobSearcherDbContextCommandDbContext, int>, IAdvertisementCommandRepository
{
    public AdvertisementCommandRepository(JobSearcherDbContextCommandDbContext dbContext) : base(dbContext)
    {
    }
}