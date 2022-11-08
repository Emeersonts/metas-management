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

        //RETORNA REPRESENTANTE DA CÉLULA DE TRABALHO
        [HttpGet]
        [Route("VerifyRepresentantative")]
        public async Task<ActionResult> onGetVerifyRepresentantative(int ANOCICLO, int IDCELULATRABALHO)
        {
            var result = await _applicationServiceRH.onGetVerifyRepresentantative(ANOCICLO, IDCELULATRABALHO);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //LISTA DOS GESTORES COM STATUS DAS SUAS CELULAS DE TRABALHO
        [HttpGet]
        [Route("MetaMmanagerStatus")]
        public async Task<ActionResult> onMetaMmanagerStatus(int ANOCICLO, int IDCELULATRABALHO, int PAGINA, int QTPPAGINA, string BUSCA)
        {
            var result = await _applicationServiceRH.onGetMetaSimulate(ANOCICLO, IDCELULATRABALHO, 1);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
