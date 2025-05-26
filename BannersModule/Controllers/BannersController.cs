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
            //deneme
            return Ok(await bannersService.List());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(BannersCreateRequest request)
        {
            await bannersService.Create(request);

            return Ok();
        }

        [HttpGet("First")]
        public async Task<IActionResult> First()
        {
            return Ok(await campaignsService.Get());
        }

        [HttpGet("Second")]
        public async Task<IActionResult> Second()
        {
            return Ok();
        }

        [HttpGet("Conflict2")]
        public async Task<IActionResult> Conflict2()
        {
            return Ok();
        }
    }
}
