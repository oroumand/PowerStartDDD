using Zamin.Core.Domain.Events;

namespace JobSearcher.Core.Domain.Advertisements.Events;

public sealed record AdvertisementDeleted(Guid BusinessId, int Id) : IDomainEvent;
