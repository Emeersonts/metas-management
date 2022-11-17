using DocumentFormat.OpenXml.Packaging;
using Metas.Application.DTO;
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

        // LISTA DE GESTORES
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
        public async Task<ActionResult> onGetListCelula([FromQuery] int IDGESTOR)
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
        public async Task<ActionResult> onGetMetaSimulate([FromQuery] int ANOCICLO, int IDCELULATRABALHO, int MES)
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
        public async Task<ActionResult> onGetVerifyRepresentantative([FromQuery] int ANOCICLO, int IDCELULATRABALHO)
        {
            var result = await _applicationServiceRH.onGetVerifyRepresentantative(ANOCICLO, IDCELULATRABALHO);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //FORMULÁRIO DE METAS RH -LISTA DOS GESTORES COM STATUS DAS SUAS CELULAS DE TRABALHO
        [HttpGet]
        [Route("MetaMmanagerStatus")]
        public async Task<ActionResult> onMetaMmanagerStatus([FromQuery] int ANOCICLO,int PAGINA, int QTPAGINA, string BUSCA)
        {
            var result = await _applicationServiceRH.onGetMetaMmanagerStatus(ANOCICLO, PAGINA, QTPAGINA, BUSCA);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //LISTA DE COLABORADORES (GERAL)
        [HttpGet]
        [Route("DropCollaborator")]
        public async Task<ActionResult> DropCollaborator()
        {
            var result = await _applicationServiceRH.onDropCollaborator();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //LISTA DE COLABORADORES POR REPRESENTANTE
        [HttpGet]
        [Route("DropEqipCollaborator")]
        public async Task<ActionResult> DropEqipCollaborator(int IDCELULATRABALHO)
        {
            var result = await _applicationServiceRH.onDropEqipCollaborator(IDCELULATRABALHO);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
