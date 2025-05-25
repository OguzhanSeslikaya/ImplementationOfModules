using ModulesForSubtree.CampaignsModule.Services.Dtos;

namespace ModulesForSubtree.CampaignsModule.Services
{
    public interface ICampaignsService
    {
        Task Create(CampaignsCreateRequest request);
        Task<List<CampaignsListResult>> List();
    }
}
