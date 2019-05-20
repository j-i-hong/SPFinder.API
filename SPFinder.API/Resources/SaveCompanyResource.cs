using System.ComponentModel.DataAnnotations;

namespace SPFinder.API.Resources
{
    public class SaveCompanyResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
