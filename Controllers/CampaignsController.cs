using Microsoft.AspNetCore.Mvc;
using ModulesForSubtree.CampaignsModule.Services;
using ModulesForSubtree.CampaignsModule.Services.Dtos;

namespace ModulesForSubtree.CampaignsModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController(ICampaignsService campaignsService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await campaignsService.List());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CampaignsCreateRequest request)
        {
            await campaignsService.Create(request);

            return Ok();
        }
    }
}
