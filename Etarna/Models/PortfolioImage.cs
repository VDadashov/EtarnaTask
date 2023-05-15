namespace Etarna.Models
{
    public class PortfolioImage : BaseEntity
    {
        public string Image { get; set; }
        public string FieldName { get; set; }
        public IEnumerable<PortfolioDetailAndClientAndImageRelationManyToMany> PortfolioDetailAndClientAndImageRelationManyToManies { get; set; }

    }
}
