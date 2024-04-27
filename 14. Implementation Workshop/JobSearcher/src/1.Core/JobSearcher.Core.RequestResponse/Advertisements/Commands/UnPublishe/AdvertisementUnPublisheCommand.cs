using Zamin.Core.RequestResponse.Commands;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.UnPublishe;

public sealed class AdvertisementUnPublisheCommand : ICommand
{
    public int Id { get; set; }
}