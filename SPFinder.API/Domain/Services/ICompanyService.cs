using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using SPFinder.API.Domain.Models;
using SPFinder.API.Domain.Services.Responses;

namespace SPFinder.API.Domain.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> ListAsync();
        Task<CompanyResponse> SaveAsync(Company company);
        Task<CompanyResponse> UpdateAsync(Guid id, Company company);

        Task<CompanyResponse> DeleteAsync(Guid id);
    }
}
