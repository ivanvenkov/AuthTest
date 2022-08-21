using AuthTest.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthTest.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> List([FromHeader] HeaderViewModel headerVM)
        {            
            if (headerVM.XInput == "asdASD")
            {
                var result = AuthTestDB.Db.Items;
                return Ok(result);
            }
            else
            {
                return Unauthorized();
            }            
        }
    }
}