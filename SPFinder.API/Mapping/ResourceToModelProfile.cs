using AutoMapper;
using SPFinder.API.Domain.Models;
using SPFinder.API.Resources;

namespace SPFinder.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCompanyResource, Company>();
        }
    }
}
