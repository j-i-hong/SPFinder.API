using AutoMapper;
using SPFinder.API.Domain.Models;
using SPFinder.API.Extensions;
using SPFinder.API.Resources;

namespace SPFinder.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Company, CompanyResource>()
                .ForMember(src => src.TierString, opt => opt.MapFrom(src => src.Tier.ToDescriptionString()));

            CreateMap<UIComponent, UIComponentResource>();
        }
    }
}
