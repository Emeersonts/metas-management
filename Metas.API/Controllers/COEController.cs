using Metas.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    public class COEController : Controller
    {

        private readonly IAplicationServiceCOE _applicationServiceCOE;
        public COEController(IAplicationServiceCOE ApplicationServiceCOE)
        {
            this._applicationServiceCOE = ApplicationServiceCOE;
        }

        // LISTA DE FORMULÁRIO
        [HttpGet]
        [Route("ListForm")]
        public async Task<ActionResult> onGetListForm([FromQuery] int IDCELULATRABALHO)
        {
            var result = await _applicationServiceCOE.onGetListForm(IDCELULATRABALHO);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
