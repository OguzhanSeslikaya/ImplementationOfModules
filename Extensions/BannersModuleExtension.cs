using Microsoft.EntityFrameworkCore;
using ModulesForSubtree.BannersModule.Contexts;
using ModulesForSubtree.BannersModule.Services;

namespace ModulesForSubtree.BannersModule.Extensions
{
    public static class BannersModuleExtension
    {
        public static void AddBannersModule(this IServiceCollection services, string sqlServerConnectionString)
        {
            services.AddDbContext<BannersModuleDbContext>(opt => opt.UseSqlServer(sqlServerConnectionString));

            services.AddTransient<IBannersService, BannersService>();
        }
    }
}
