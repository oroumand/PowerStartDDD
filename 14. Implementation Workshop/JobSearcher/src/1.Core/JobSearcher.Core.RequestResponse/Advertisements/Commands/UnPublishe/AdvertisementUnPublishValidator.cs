using FluentValidation;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.UnPublishe;

public sealed class AdvertisementUnPublishValidator : AbstractValidator<AdvertisementUnPublisheCommand>
{
    public AdvertisementUnPublishValidator()
    {
    }
}