using System;
using System.Collections.Generic;

namespace SPFinder.API.Domain.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string AccountNumber { get; set; }
        public bool IsActive { get; set; }
        public ProviderStatus ProviderStatus { get; set; }

        public IList<CompanyCertification> CompanyCertifications { get; set; } = new List<CompanyCertification>();
    }
}
