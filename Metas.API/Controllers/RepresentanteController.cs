using Metas.Application.DTO;
using Metas.Application.Interface;
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
        [HttpPost]
        [Route("ListIndicatorSAP")]
        public async Task<ActionResult> GetListIndicatorSAP(IndicadorDTO dto)
        {
            var result = await _applicationServiceRepresentante.OnGetFindIndicatorSAP(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de indicadores a serem incluidos (retorno)
        [HttpPost]
        [Route("ListIndicatorAdd")]
        public async Task<ActionResult> GetListIndicatorAdd(EIndicadorAddDTO dto)
        {
            Metas.Profile.pkxd.type = 1;
            var result = await _applicationServiceRepresentante.OnGetListIndicatorAdd(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Relatorio de metas
        [HttpPost]
        [Route("GoalsReport")]
        public async Task<ActionResult> GetGoalsReport(int CICLO)
        {
            Metas.Profile.pkxd.type = 1;
            var result = await _applicationServiceRepresentante.OnGetGoalsReport(CICLO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        // Lista de indicadores semestral para envio de pedido de aprovação
        [HttpPost]
        [Route("AddSIndicator")]
        public async Task<ActionResult> GetAddSIndicator(int CICLO)
        {
            Metas.Profile.pkxd.type = 1;
            var result = await _applicationServiceRepresentante.OnGetAddSIndicator(CICLO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        //Lista de solicitações
        [HttpPost]
        [Route("Listsolicitation")]
        public async Task<ActionResult> GetListsolicitation(ESolicitacaoDTO dto)
        {
            Metas.Profile.pkxd.type = 1;
            var result = await _applicationServiceRepresentante.OnGetListsolicitation(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de colaboradores (Time)
        [HttpPost]
        [Route("ListTeam")]
        public async Task<ActionResult> GetListTeam(ColaboradorDTO dto)
        {
            var result = await _applicationServiceRepresentante.OnGetFindColaborador(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Cronograma
        [HttpPost]
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



        //  Salvar indicadores       
        [HttpPost]
        [Route("SendForApprovalIndicador")]
        public async Task<ActionResult> SendForApprovalIndicador(GIndicadorDTTO dto)
        {

            var result = await _applicationServiceRepresentante.OnSendForApprovalIndicador(dto);
            
            if (result == 0)
            {
                return Ok();
            }
            else
            {  
                return Ok("Erro ao cadastrar idicador");
            }

        }

        // Remover indicador
        [HttpDelete]
        [Route("RemoveIndicador")]
        public async Task<ActionResult> RemoveIndicador(int IDINDICADOR)
        {

            var result = await _applicationServiceRepresentante.OnRemoveIndicador(IDINDICADOR);

            if (result == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(result + "-Erro ao Remover idicador. Está em uso, não pode ser removido <>");
            }

        }

        // Atializa representante
        [HttpPut]
        [Route("RepresentativeUpdate")]
        public async Task<ActionResult> RepresentativeUpdate(int IDINDICADOR)
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
    }
}
