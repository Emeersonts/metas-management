using Metas.Application.Interface;
using Metas.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RHController : Controller
    {

        private readonly IAplicationServiceRH _applicationServiceRH;
        public RHController(IAplicationServiceRH ApplicationServiceRH)
        {
            this._applicationServiceRH = ApplicationServiceRH;
        }

        // lista de gestores
        [HttpGet]
        [Route("ListGestor")]
        public async Task<ActionResult> onGetListGestor()
        {
            var result = await _applicationServiceRH.onGetListGestor();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
