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

        // LISTA UNIDADE OPERACIONAL
        [HttpGet]
        [Route("ListOperatingUnit")]
        public async Task<ActionResult> onListOperatingUnit()
        {
            var result = await _applicationServiceCOE.onListOperatingUnit();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // LISTA DE GESTORES POR UNIDADE OPERACIONAL
        [HttpGet]
        [Route("ListGestor")]
        public async Task<ActionResult> onGetListGestor(int IDUNIDADEOPERACIONAL)
        {
            var result = await _applicationServiceCOE.onGetListGestor(IDUNIDADEOPERACIONAL);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

    }
}
