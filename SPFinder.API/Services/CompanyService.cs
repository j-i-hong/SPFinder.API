using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using SPFinder.API.Domain.Models;
using SPFinder.API.Domain.Repositories;
using SPFinder.API.Domain.Services;
using SPFinder.API.Domain.Services.Responses;

namespace SPFinder.API.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork)
        {
            _companyRepository = companyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _companyRepository.ListAsync();
        }

        public async Task<CompanyResponse> SaveAsync(Company company)
        {
            try
            {
                await _companyRepository.AddAsync(company);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(company);
            }
            catch (Exception ex)
            {
                return new CompanyResponse($"An error occurred when saving the company: {ex.Message}");
            }
        }

        public async Task<CompanyResponse> UpdateAsync(Guid id, Company company)
        {
            var existingCategory = await _companyRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new CompanyResponse("Company not found.");

            existingCategory.Name = company.Name;

            try
            {
                _companyRepository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging
                return new CompanyResponse($"An error occurred when updating the company: {ex.Message}");
            }
        }

        public async Task<CompanyResponse> DeleteAsync(Guid id)
        {
            var existingCategory = await _companyRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new CompanyResponse("Company not found.");

            try
            {
                _companyRepository.Remove(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging 
                return new CompanyResponse($"An error occurred when deleting the company: {ex.Message}");
            }
        }
    }
}
