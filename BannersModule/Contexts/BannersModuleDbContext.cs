using ImplementationOfModules.BannersModule.Entities;
using Microsoft.EntityFrameworkCore;
using ModulesForSubtree.BannersModule.Entities;

namespace ModulesForSubtree.BannersModule.Contexts
{
    public class BannersModuleDbContext : DbContext
    {
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Entity2> Entity2s { get; set; }

        public BannersModuleDbContext(DbContextOptions<BannersModuleDbContext> options) : base(options)
        {
        }
    }
}
