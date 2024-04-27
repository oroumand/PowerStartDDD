using Zamin.Core.Domain.Events;

namespace JobSearcher.Core.Domain.Advertisements.Events;

public sealed record AdvertisementCreated(Guid BusinessId, string Title, string Description, int Salary, int CityId, bool IsRemote) : IDomainEvent;