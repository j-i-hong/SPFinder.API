using SPFinder.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPFinder.API.Domain.Services
{
    public interface IUIComponentService
    {
        Task<IEnumerable<UIComponent>> GetIndustries();
        Task<IEnumerable<UIComponent>> GetServices();
        Task<IEnumerable<UIComponent>> GetGS1USCertifiedServices();
        Task<IEnumerable<UIComponent>> GetSoftwareOptions();
        Task<IEnumerable<UIComponent>> GetHardwareOptions();
    }
}
