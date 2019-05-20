using SPFinder.API.Domain.Models;
using System;
using System.Collections.Generic;

namespace SPFinder.API.Resources
{
    public class CompanyResource
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string AccountNumber { get; set; }
        public bool IsActive { get; set; }          // this should be true for public listing
        //public TierResource TierResource { get; set; }
        public Tier Tier { get; set; }
        public string TierString { get; set; }

        public IList<CompanyCertificateResource> CompanyCertifications { get; set; } = new List<CompanyCertificateResource>();
    }
}
