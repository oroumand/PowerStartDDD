using FluentValidation;

namespace JobSearcher.Core.RequestResponse.Advertisements.Commands.Delete;

public sealed class AdvertisementDeleteValidator : AbstractValidator<AdvertisementDeleteCommand>
{
    public AdvertisementDeleteValidator()
    {
    }
}