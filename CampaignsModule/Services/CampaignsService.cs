using ImplementationOfModules.CampaignsModule.Services.Dtos;
using Microsoft.EntityFrameworkCore;
using ModulesForSubtree.CampaignsModule.Contexts;
using ModulesForSubtree.CampaignsModule.Entities;
using ModulesForSubtree.CampaignsModule.Services.Dtos;

namespace ModulesForSubtree.CampaignsModule.Services
{
    public class CampaignsService(CampaignsModuleDbContext campaignsDbContext) : ICampaignsService
    {
        public async Task Create(CampaignsCreateRequest request)
        {
            await campaignsDbContext.AddAsync(new Campaign
            {
                Name = request.Name,
                CreatedDate = DateTime.UtcNow,
            });

            await campaignsDbContext.SaveChangesAsync();
        }

        public async Task<CampaignsFirstResult?> Get()
        {
            return await campaignsDbContext.Campaigns.Select(a => new CampaignsFirstResult
            {
                Id = a.Id,
                CreatedDate = a.CreatedDate,
                Name = a.Name
            }).FirstOrDefaultAsync();
        }

        public async Task<List<CampaignsListResult>> List()
        {
            return await campaignsDbContext.Campaigns
                .Select(a => new CampaignsListResult
                {
                    Name = a.Name,
                    CreatedDate = a.CreatedDate,
                    Id = a.Id
                }).ToListAsync();
        }
    }
}
