using FluentValidation;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.Create;

public sealed class AdvertisementCreateValidator : AbstractValidator<AdvertisementCreateCommand>
{
    public AdvertisementCreateValidator()
    {
    }
}