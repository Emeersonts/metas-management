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

        //LISTA DE CELULAS DE TRABALHO DE DETERMINADO GESTOR
        [HttpGet]
        [Route("ListCelula")]
        public async Task<ActionResult> onGetListCelula(int IDGESTOR)
        {
            var result = await _applicationServiceRH.onGetListCelula(IDGESTOR);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //LISTA AS METAS DA CELULA ESCOLHIDA PARA SIMULAÇÃO
        [HttpGet]
        [Route("MetaSimulate")]
        public async Task<ActionResult> onGetMetaSimulate(int ANOCICLO, int IDCELULATRABALHO, int MES)
        {
            var result = await _applicationServiceRH.onGetMetaSimulate(ANOCICLO,IDCELULATRABALHO,MES);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
