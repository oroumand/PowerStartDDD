using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetById;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetPagedFilter;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetSelectList;

namespace JobSearcher.Infra.Data.Sql.Queries.Advertisements.Entities;

public sealed class Advertisement
{
    public int Id { get; set; }
    public Guid BusinessId { get; set; }


    public static explicit operator AdvertisementQr(Advertisement entity) => new()
    {
        Id = entity.Id
    };

    public static explicit operator AdvertisementSelectItemQr(Advertisement entity) => new()
    {
        Id = entity.Id
    };

    public static explicit operator AdvertisementListItemQr(Advertisement entity) => new()
    {
        Id = entity.Id
    };
}
