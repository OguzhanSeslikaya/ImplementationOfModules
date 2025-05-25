using Microsoft.EntityFrameworkCore;
using ModulesForSubtree.CampaignsModule.Entities;

namespace ModulesForSubtree.CampaignsModule.Contexts
{
    public class CampaignsModuleDbContext : DbContext
    {
        public DbSet<Campaign> Campaigns { get; set; }

        public CampaignsModuleDbContext(DbContextOptions<CampaignsModuleDbContext> options) : base(options)
        {
        }
    }
}
