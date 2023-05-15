using Etarna.Models;

namespace Etarna.ViewModel.Portfolio
{
    public class PortfolioVm
    {
        public IEnumerable<PortfolioDetail> PortfolioDetails { get; set; }
        public IEnumerable<PortfolioImage> PortfolioImages { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<PortfolioDetailAndClientAndImageRelationManyToMany> PortfolioDetailAndClientAndImageRelationManyToManies { get; set; }
    }
}
