using System.Security.Principal;

namespace Etarna.Models
{
    public class PortfolioDetail : BaseEntity
    {
        public string Description { get; set; }
        public DateTime ProjectDate { get; set; }
        public IEnumerable<PortfolioDetailAndClientAndImageRelationManyToMany> PortfolioDetailAndClientAndImageRelationManyToManies { get; set; }
    }
}
