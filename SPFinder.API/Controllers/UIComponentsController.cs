using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPFinder.API.Domain.Models;
using SPFinder.API.Domain.Services;
using SPFinder.API.Resources;

namespace SPFinder.API.Controllers
{
    [Route("v1/[controller]/[action]")]
    [ApiController]
    public class UIComponentsController : ControllerBase
    {
        private readonly IUIComponentService _uiComponentService;
        private readonly IMapper _mapper;

        public UIComponentsController(IUIComponentService service, IMapper mapper)
        {
            _uiComponentService = service;
            _mapper = mapper;
        }

        [HttpGet]
        [ActionName("Industries")]
        public async Task<IEnumerable<UIComponentResource>> GetIndustries()
        {
            IEnumerable<UIComponent> industries = await _uiComponentService.GetIndustries();

            // map domain obj to response
            IEnumerable<UIComponentResource> resource = _mapper.Map<IEnumerable<UIComponent>, IEnumerable<UIComponentResource>>(industries);

            return resource;
        }

        [HttpGet]
        [ActionName("ServiceTypes")]
        public async Task<IEnumerable<UIComponentResource>> GetServices()
        {
            IEnumerable<UIComponent> uIComponents = await _uiComponentService.GetServices();

            IEnumerable<UIComponentResource> resource = _mapper.Map<IEnumerable<UIComponent>, IEnumerable<UIComponentResource>>(uIComponents);

            return resource;
        }

        [HttpGet]
        [ActionName("CertifiedServices")]
        public async Task<IEnumerable<UIComponentResource>> GetCertifiedServices()
        {
            IEnumerable<UIComponent> uIComponents = await _uiComponentService.GetGS1USCertifiedServices();

            IEnumerable<UIComponentResource> resource = _mapper.Map<IEnumerable<UIComponent>, IEnumerable<UIComponentResource>>(uIComponents);

            return resource;
        }

        [HttpGet]
        [ActionName("SoftwareOptions")]
        public async Task<IEnumerable<UIComponentResource>> GetSoftwareOptions()
        {
            IEnumerable<UIComponent> uIComponents = await _uiComponentService.GetSoftwareOptions();

            IEnumerable<UIComponentResource> resource = _mapper.Map<IEnumerable<UIComponent>, IEnumerable<UIComponentResource>>(uIComponents);

            return resource;
        }

        [HttpGet]
        [ActionName("HardwareOptions")]
        public async Task<IEnumerable<UIComponentResource>> GetHardwareOptions()
        {
            IEnumerable<UIComponent> uIComponents = await _uiComponentService.GetHardwareOptions();

            IEnumerable<UIComponentResource> resource = _mapper.Map<IEnumerable<UIComponent>, IEnumerable<UIComponentResource>>(uIComponents);

            return resource;
        }
    }
}