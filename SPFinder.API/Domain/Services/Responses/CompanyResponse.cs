using SPFinder.API.Domain.Models;

namespace SPFinder.API.Domain.Services.Responses
{
    public class CompanyResponse : BaseResponse
    {
        public Company Company { get; private set; }

        private CompanyResponse(bool success, string message, Company company) : base(success, message)
        {
            Company = company;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="company">company Saved</param>
        /// <returns>Response.</returns>
        public CompanyResponse(Company company) : this(true, string.Empty, company)
        { }

        /// <summary>
        /// Creates an error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public CompanyResponse(string message) : this(false, message, null)
        { }
    }
}
