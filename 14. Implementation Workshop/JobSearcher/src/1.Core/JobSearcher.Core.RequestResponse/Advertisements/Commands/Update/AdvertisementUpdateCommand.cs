using Zamin.Core.RequestResponse.Commands;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.Update;

public sealed class AdvertisementUpdateCommand : ICommand
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int CityId { get; set; }
    public int Salary { get; set; }
    public bool IsRemote { get; set; }

}