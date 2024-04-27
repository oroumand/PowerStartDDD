using Zamin.Core.Contracts.Data.Commands;
using JobSearcher.Core.Domain.Advertisements.Entities;
using JobSearcher.Core.Domain.Advertisemetns.Entities;

namespace JobSearcher.Core.Contracts.Advertisements.Commands;

public interface IAdvertisementCommandRepository : ICommandRepository<Advertisement, int>
{
}