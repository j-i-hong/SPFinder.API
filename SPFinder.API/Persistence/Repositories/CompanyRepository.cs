using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SPFinder.API.Domain.Models;
using SPFinder.API.Domain.Repositories;
using SPFinder.API.Persistence.Contexts;


namespace SPFinder.API.Persistence.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        public  Task AddAsync(Company company)
        {
            return _context.Companies.AddAsync(company);
        }

        public async Task<Company> FindByIdAsync(Guid id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _context.Companies
                .Include(p => p.CompanyCertifications)
                .ToListAsync();
        }

        public void Remove(Company company)
        {
            _context.Companies.Remove(company);
        }

        public void Update(Company company)
        {
            _context.Companies.Update(company);
        }
    }
}
