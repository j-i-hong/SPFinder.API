using System;

namespace SPFinder.API.Domain.Models
{
    public class CompanyCertification : Certification
    {
        // for relationship
        public Guid CompanyId { get; set; }  
        public Company Company { get; set; }
    }
}
