using Zamin.Core.Domain.Events;

namespace JobSearcher.Core.Domain.Advertisements.Events;

public sealed record AdvertisementPublished(Guid BusinessId, int Id, DateTime PublisheDate) : IDomainEvent;
