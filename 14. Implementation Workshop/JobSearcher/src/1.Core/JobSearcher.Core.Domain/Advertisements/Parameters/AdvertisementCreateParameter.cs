namespace JobSearcher.Core.Domain.Advertisements.Parameters;

public sealed record class AdvertisementCreateParameter(string Title, string Description, int Salary, int CityId, bool IsRemote);