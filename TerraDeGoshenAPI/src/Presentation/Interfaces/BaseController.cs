using Microsoft.AspNetCore.Mvc;

namespace TerraDeGoshenAPI.src.Presentation
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        public BaseController()
        { }
    }
}