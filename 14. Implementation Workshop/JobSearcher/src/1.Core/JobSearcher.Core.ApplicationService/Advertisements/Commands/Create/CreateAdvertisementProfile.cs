using AutoMapper;
using JobSearcher.Core.Domain.Advertisements.Parameters;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Create;

namespace JobSearcher.Core.ApplicationService.Advertisements.Commands.Create
{
    public class CreateAdvertisementProfile : Profile
    {
        public CreateAdvertisementProfile()
        {
            CreateMap<AdvertisementCreateCommand, AdvertisementCreateParameter>().ReverseMap();
        }
    }
}
