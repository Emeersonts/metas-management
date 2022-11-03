using Metas.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RHController : Controller
    {
        [HttpGet]
        [Route("ListProgressStatus")]
        public async Task<ActionResult> GetListProgressStatus([FromQuery] int CICLO)
        {

            return Ok();
        }
    }
}
