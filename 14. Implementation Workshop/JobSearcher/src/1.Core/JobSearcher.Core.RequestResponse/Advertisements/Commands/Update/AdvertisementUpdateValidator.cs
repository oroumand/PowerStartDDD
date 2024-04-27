using FluentValidation;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.Update;

public sealed class AdvertisementUpdateValidator : AbstractValidator<AdvertisementUpdateCommand>
{
    public AdvertisementUpdateValidator()
    {
    }
}