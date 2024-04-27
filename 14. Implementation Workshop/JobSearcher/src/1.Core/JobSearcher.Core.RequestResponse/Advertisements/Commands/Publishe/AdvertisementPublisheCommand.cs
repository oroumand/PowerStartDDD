using Zamin.Core.RequestResponse.Commands;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.Publishe;

public sealed class AdvertisementPublisheCommand : ICommand
{
    public int Id { get; set; }
}