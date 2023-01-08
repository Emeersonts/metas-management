using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Profile;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GestorController : Controller
    {
        private readonly IAplcationServiceGestor  _applicationServiceGestor;
        public GestorController(IAplcationServiceGestor ApplicationServigestor)
        {
            this._applicationServiceGestor = ApplicationServigestor;
        }

        // Visualizar equipe
        [HttpGet]
        [Route("VializeTeam")] 
        public async Task<ActionResult> GetTeam([FromQuery] int CICLO)
        {
            var result = await _applicationServiceGestor.OnVializeTeam(CICLO);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //* Tipo de formulario
        [HttpGet]
        [Route("FormTtype")]
        public async Task<ActionResult> GetFormTtype([FromQuery] int CICLO)
        {
            var result = await _applicationServiceGestor.OnGetFormTtype(CICLO);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // Atualiza tipo de formulario
        [HttpPost]
        [Route("SaveFormEditType")]
        public async Task<ActionResult> SaveFormEditType(TipoEdicaoformularioDTO dto)
        {
            var result = await _applicationServiceGestor.onSaveFormEditType(dto);
            var ob = new InterrupcaoDTO();

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(ob.IT(result));
            }
        }

        // lista de metas da celula 
        [HttpGet]
        [Route("ListMeta")]
        public async Task<ActionResult> GetMetasByUsuarioCiclo([FromQuery] CicloCelulaDTO dto)
        {
            var result = await _applicationServiceGestor.OnGetFindMeta(dto, new pkxd(0, 1, 1, 1, dto.IDCELULATRABALHO));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de resultados por celula de trabalho
        [HttpGet]
        [Route("ListMetaResultado")]
        public async Task<ActionResult> GetMetasByUsuarioCicloResult([FromQuery] int ANOCICLO, int IDCELULATRABALHO)
        {
            var result = await _applicationServiceGestor.OnGetFindMetaResult(ANOCICLO, IDCELULATRABALHO, new pkxd(0, 1, 1, 1, 1));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //PEDIDO DE REVISÃOD E RESUTADOS
        [HttpGet]
        [Route("ReviewResults")]
        public async Task<ActionResult> GetReviewResults([FromQuery] int ANOCICLO, int IDCELULATRABALHO)
        {
            var result = await _applicationServiceGestor.OnGetReviewResults(ANOCICLO,IDCELULATRABALHO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de colaboradores da celula escolhida
        [HttpGet]
        [Route("ListTeam")]
        public async Task<ActionResult> GetListTeam([FromQuery] ColaboradorDTO dto, int QTPAGINA, int IDCELULATRABALHO, int ACNOCICLO)
        {
            var result = await _applicationServiceGestor.OnGetFindColaborador(dto.PAGINA, QTPAGINA, IDCELULATRABALHO, ACNOCICLO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //Lista de solicitações
        [HttpGet]
        [Route("Listsolicitation")]
        public async Task<ActionResult> GetListsolicitation([FromQuery] ESolicitacaoDTO dto, int ANOCICLO, int PAGINA, int NPAGINA, int IDCELULATRABALHO)
        {
            var result = await _applicationServiceGestor.OnGetListsolicitation(dto, ANOCICLO, PAGINA, NPAGINA, IDCELULATRABALHO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Solicitar ajuste apos solicitação de aprovação de indicadores
        [HttpPost]
        [Route("RequestAdjustment")]
        public async Task<ActionResult> RequestAdjustment([FromQuery] int ANOCICLO, int IDCELULATRABALHO, string MENSSAGEM)
        {

            var result = await _applicationServiceGestor.OnRequestAdjustment(ANOCICLO, IDCELULATRABALHO , MENSSAGEM);
            var ob = new InterrupcaoDTO();

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(ob.IT(result));
            }
        }

        //solicita ajuste no resultado dos indicadores
        [HttpPost]
        [Route("RequestAdjustmentResult")]
        public async Task<ActionResult> RequestAdjustmentResult([FromQuery] int ANOCICLO, int IDCELULATRABALHO, string MENSSAGEM)
        {

            var result = await _applicationServiceGestor.OnRequestAdjustmentResult(ANOCICLO, IDCELULATRABALHO, MENSSAGEM);
            var ob = new InterrupcaoDTO();

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(ob.IT(result));
            }
        }

        // Aprovar indicadores
        [HttpPost]
        [Route("AprovarIndicador")]
        public async Task<ActionResult> AprovarIndicador([FromQuery] int ANOCICLO, int IDCELULATRABALHO)
        {

            var result = await _applicationServiceGestor.OnAprovarIndicador(ANOCICLO, IDCELULATRABALHO);
            var ob = new InterrupcaoDTO();

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(ob.IT(result));
            }
        }

        // Aprovar resultados
        [HttpPost]
        [Route("AprovarResults")]
        public async Task<ActionResult> AprovarResults([FromQuery] int ANOCICLO, int IDCELULATRABALHO)
        {

            var result = await _applicationServiceGestor.OnAprovarResults(ANOCICLO, IDCELULATRABALHO);
            var ob = new InterrupcaoDTO();

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(ob.IT(result));
            }
        }
        // aprovar resultados jul
        [HttpPost]
        [Route("AprovarResultsJul")]
        public async Task<ActionResult> AprovarResultsJul([FromQuery] int ANOCICLO, int IDCELULATRABALHO)
        {

            var result = await _applicationServiceGestor.OnAprovarResultsJul(ANOCICLO, IDCELULATRABALHO);
            var ob = new InterrupcaoDTO();

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(ob.IT(result));
            }
        }

    }
}
