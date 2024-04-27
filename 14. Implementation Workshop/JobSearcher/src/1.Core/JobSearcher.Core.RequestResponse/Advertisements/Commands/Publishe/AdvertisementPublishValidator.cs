using FluentValidation;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.Publishe;

public sealed class AdvertisementPublishValidator : AbstractValidator<AdvertisementPublisheCommand>
{
    public AdvertisementPublishValidator()
    {
    }
}