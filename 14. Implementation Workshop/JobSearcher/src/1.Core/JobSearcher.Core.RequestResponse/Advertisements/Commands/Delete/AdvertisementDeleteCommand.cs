using Zamin.Core.RequestResponse.Commands;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.Delete;

public sealed class AdvertisementDeleteCommand : ICommand
{
    public int Id { get; set; }
}