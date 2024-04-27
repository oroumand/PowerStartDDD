namespace JobSearcher.Core.Domain.Advertisements.Parameters;

public sealed record class AdvertisementUpdateParameter(string Title, string Description, int Salary, int CityId, bool IsRemote);