using Microsoft.AspNetCore.Mvc;
using ModulesForSubtree.BannersModule.Services;
using ModulesForSubtree.BannersModule.Services.Dtos;
using ModulesForSubtree.CampaignsModule.Services;

namespace ModulesForSubtree.BannersModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IBannersService bannersService, ICampaignsService campaignsService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await bannersService.List());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(BannersCreateRequest request)
        {
            await bannersService.Create(request);

            return Ok();
        }

        [HttpGet("First")]
        public async Task<IActionResult> deneme()
        {
            return Ok(await campaignsService.Get());
        }
    }
}
