using System.ComponentModel;

namespace SPFinder.API.Domain.Models
{
    public enum Tier 
    {
        [Description("Silver")]
        Silver = 1,

        [Description("Gold")]
        Gold = 2,

        [Description("Elite")]
        Elite = 3,
    }
}
