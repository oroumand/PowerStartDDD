using Zamin.Core.RequestResponse.Queries;

namespace JobSearcher.Core.RequestResponse.Advertisements.Queries.GetById;

public sealed class AdvertisementGetByIdQuery : IQuery<AdvertisementQr?>
{
    public int Id { get; set; }
}