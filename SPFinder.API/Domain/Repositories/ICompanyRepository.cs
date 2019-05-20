using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SPFinder.API.Domain.Models;

namespace SPFinder.API.Domain.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAsync();
        Task<Company> FindByIdAsync(Guid id);

        Task AddAsync(Company company);
        void Update(Company company);
        void Remove(Company company);
    }
}
