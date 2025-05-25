using Microsoft.AspNetCore.Mvc;
using ModulesForSubtree.BannersModule.Services;
using ModulesForSubtree.BannersModule.Services.Dtos;

namespace ModulesForSubtree.BannersModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IBannersService bannersService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            //denemeasd
            return Ok(await bannersService.List());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(BannersCreateRequest request)
        {
            await bannersService.Create(request);

            return Ok();
        }
    }
}
