namespace Etarna.Models
{
    public class PortfolioDetailAndClientAndImageRelationManyToMany
    {
        public int Id { get; set; }
        public int PortfolioDetailId { get; set; }
        public PortfolioDetail PortfolioDetail { get; set; }
        public int PortfolioImageId { get; set; }
        public PortfolioImage PortfolioImage { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
