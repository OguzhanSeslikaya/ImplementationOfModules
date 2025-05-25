using Microsoft.EntityFrameworkCore;
using ModulesForSubtree.BannersModule.Entities;

namespace ModulesForSubtree.BannersModule.Contexts
{
    public class BannersModuleDbContext : DbContext
    {
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Entity1> Entity1s { get; set; }

        public BannersModuleDbContext(DbContextOptions<BannersModuleDbContext> options) : base(options)
        {
        }
    }
}
