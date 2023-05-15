using Microsoft.EntityFrameworkCore;
using Etarna.Models;

namespace Etarna.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Featured> Featureds { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }
        public DbSet<PortfolioDetail> PortfolioDetails { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<PortfolioDetailAndClientAndImageRelationManyToMany> PortfolioDetailAndClientAndImageRelationManyToManies { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
