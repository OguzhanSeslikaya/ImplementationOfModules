using Microsoft.EntityFrameworkCore;
using ModulesForSubtree.CampaignsModule.Contexts;
using ModulesForSubtree.CampaignsModule.Services;

namespace ModulesForSubtree.CampaignsModule.Extensions
{
    public static class CampaignsModuleExtension
    {
        public static void AddCampaignsModule(this IServiceCollection services, string sqlServerConnectionString)
        {
            services.AddDbContext<CampaignsModuleDbContext>(opt => opt.UseSqlServer(sqlServerConnectionString));

            services.AddTransient<ICampaignsService, CampaignsService>();
        }
    }
}
