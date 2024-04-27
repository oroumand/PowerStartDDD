using AutoMapper;
using JobSearcher.Core.Domain.Advertisements.Parameters;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Create;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Update;

namespace JobSearcher.Core.ApplicationService.Advertisements.Commands.Update
{
    public class UpdateAdvertisementProfile : Profile
    {
        public UpdateAdvertisementProfile()
        {
            CreateMap<AdvertisementUpdateCommand, AdvertisementUpdateParameter>().ReverseMap();
        }
    }
}
