using AutoMapper;
using SPFinder.API.Domain.Models;
using SPFinder.API.Resources;

namespace SPFinder.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Company, CompanyResource>();
            CreateMap<UIComponent, UIComponentResource>();
        }
    }
}
