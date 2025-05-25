using Microsoft.EntityFrameworkCore;
using ModulesForSubtree.BannersModule.Contexts;
using ModulesForSubtree.BannersModule.Entities;
using ModulesForSubtree.BannersModule.Services.Dtos;

namespace ModulesForSubtree.BannersModule.Services
{
    public class BannersService(BannersModuleDbContext bannersModuleDbContext) : IBannersService
    {
        public async Task Create(BannersCreateRequest request)
        {
            await bannersModuleDbContext.AddAsync(new Banner
            {
                Name = request.Name,
                CreatedDate = DateTime.UtcNow,
            });

            await bannersModuleDbContext.SaveChangesAsync();
        }

        public async Task<List<BannersListResult>> List()
        {
            return await bannersModuleDbContext.Banners
                .Select(a => new BannersListResult
                {
                    Name = a.Name,
                    CreatedDate = a.CreatedDate,
                    Id = a.Id
                }).ToListAsync();
        }
    }
}
