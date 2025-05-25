using ModulesForSubtree.BannersModule.Services.Dtos;

namespace ModulesForSubtree.BannersModule.Services
{
    public interface IBannersService
    {
        Task Create(BannersCreateRequest request);
        Task<List<BannersListResult>> List();
    }
}
