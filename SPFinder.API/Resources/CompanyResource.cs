using System;
using System.Collections.Generic;

namespace SPFinder.API.Resources
{
    public class CompanyResource
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string AccountNumber { get; set; }
        public bool IsActive { get; set; }          // this should be true for public listing

        public IList<CompanyCertificateResource> CompanyCertifications { get; set; } = new List<CompanyCertificateResource>();
    }
}
