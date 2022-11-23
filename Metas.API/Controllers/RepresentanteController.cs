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
    [Route("Representante/")]

    public class RepresentanteController : Controller
    {
        private readonly IAplicationServiceRepresetante _applicationServiceRepresentante;

        public RepresentanteController(IAplicationServiceRepresetante ApplicationServiceRepresentante)
        {
            this._applicationServiceRepresentante = ApplicationServiceRepresentante;
        }

        // Lista de indicadores (SAP)
        [HttpGet]
        [Route("ListIndicatorSAP")]
        public async Task<ActionResult> GetListIndicatorSAP([FromQuery] IndicadorDTO dto)
        {
            var result = await _applicationServiceRepresentante.OnGetFindIndicatorSAP(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de indicadores a serem incluidos (retorno)
        [HttpGet]
        [Route("ListIndicatorAdd")]
        public async Task<ActionResult> GetListIndicatorAdd([FromQuery] EIndicadorAddDTO dto)
        {
            var result = await _applicationServiceRepresentante.OnGetListIndicatorAdd(dto, new pkxd(1,1,1,1,1));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Relatorio de metas
        [HttpGet]
        [Route("GoalsReport")]
        public async Task<ActionResult> GetGoalsReport([FromQuery] int CICLO)
        {
            var result = await _applicationServiceRepresentante.OnGetGoalsReport(CICLO, new pkxd(0,1,1,1,1));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        // Lista de indicadores semestral para envio de pedido de aprovação
        [HttpGet]
        [Route("AddSIndicator")]
        public async Task<ActionResult> GetAddSIndicator([FromQuery] int CICLO)
        {
            var result = await _applicationServiceRepresentante.OnGetAddSIndicator(CICLO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //Lista de solicitações
        [HttpGet]
        [Route("Listsolicitation")]
        public async Task<ActionResult> GetListsolicitation([FromQuery] ESolicitacaoDTO dto, int ANOCICLO)
        {
            var result = await _applicationServiceRepresentante.OnGetListsolicitation(dto, ANOCICLO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de colaboradores (Time)
        [HttpGet]
        [Route("ListTeam")]
        public async Task<ActionResult> GetListTeam([FromQuery] ColaboradorDTO dto, int QTPAGINA)
        {
            var result = await _applicationServiceRepresentante.OnGetFindColaborador(dto.PAGINA, QTPAGINA);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Cronograma
        [HttpGet]
        [Route("Timeline")]
        public async Task<ActionResult> Timeline()
        {
            var result = await _applicationServiceRepresentante.OnTimeline();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        int log = 0;
        //Salvar indicadores       
        [HttpPost]
        [Route("SaveForm")]
        public async Task<ActionResult> SaveForm(GIndicadorDTTO dto)
        {
            
            var result = await _applicationServiceRepresentante.OnSaveForm(dto);
            var ob = new InterrupcaoDTO();

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(ob.IT(result) );
            }


        }

        //Envia indicadores para aprovação
        [HttpPost]
        [Route("SendForApprovalIndicador")]
        public async Task<ActionResult> SendForApprovalIndicador([FromQuery] int ANOCICLO)
        {

            var result = await _applicationServiceRepresentante.OnSendForApprovalIndicador(ANOCICLO);
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

        // Enviar resultados para solicitação de aprovação
        [HttpPost]
        [Route("SendResultForApproval")]
        public async Task<ActionResult> SendResultForApproval([FromQuery] int ANOCICLO)
        {

            var result = await _applicationServiceRepresentante.OnSendResultForApproval(ANOCICLO);
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

        // Remover indicador
        [HttpDelete]
        [Route("RemoveIndicador")]
        public async Task<ActionResult> RemoveIndicador([FromQuery] int IDINDICADOR)
        {

            var result = await _applicationServiceRepresentante.OnRemoveIndicador(IDINDICADOR);
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

        // Atializa representante
        [HttpPut]
        [Route("RepresentativeUpdate")]
        public async Task<ActionResult> RepresentativeUpdate([FromQuery] int IDINDICADOR)
        {

            var result = await _applicationServiceRepresentante.OnRemoveIndicador(IDINDICADOR);

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok("Erro ao Remover idicador. Está em uso, não pode ser removido <>");
            }

        }

        // lsita de pocessos(SAP)
        [HttpGet]
        [Route("GetListProcess")]
        public async Task<ActionResult> GetListProcess()
        {

            var result = await _applicationServiceRepresentante.OnGetListProcess();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }

    }
}
