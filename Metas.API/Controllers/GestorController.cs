﻿using Metas.Application.DTO;
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
        public async Task<ActionResult> GetListTeam([FromQuery] ColaboradorDTO dto, int QTPAGINA, int IDCELULATRABALHO)
        {
            var result = await _applicationServiceGestor.OnGetFindColaborador(dto.PAGINA, QTPAGINA, IDCELULATRABALHO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //Lista de solicitações
        [HttpGet]
        [Route("Listsolicitation")]
        public async Task<ActionResult> GetListsolicitation([FromQuery] ESolicitacaoDTO dto, int ANOCICLO, int IDCELULATRABALHO)
        {
            var result = await _applicationServiceGestor.OnGetListsolicitation(dto, ANOCICLO, IDCELULATRABALHO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
