﻿using Metas.Application.DTO;
using Metas.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    [ApiController]
    [Route("Colaborador/")]

    public class ColaboradorController : Controller
    {

        private readonly IAplicationServiceColaborador _applicationServiceColaborador;

        public ColaboradorController(IAplicationServiceColaborador ApplicationServiceColaborador)
        {
            this._applicationServiceColaborador = ApplicationServiceColaborador;
        }

        // Lista a meta do colaborador
        [HttpGet]
        [Route("ListMeta")]
        public async Task<ActionResult> GetMetasByUsuarioCiclo([FromQuery] CicloUsuarioDTO dto  ) 
        {
            var result = await _applicationServiceColaborador.OnGetFindMeta(dto); 
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de Metas equipes anterior
        [HttpGet]
        [Route("ListMetaPrevius")]
        public async Task<ActionResult> GetMetasPreviusByUsuarioCiclo([FromQuery] CicloUsuarioDTO dto)
        {
            Metas.Profile.pkxd.type = 1;
            var result = await _applicationServiceColaborador.OnGetFindMeta(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // lista de resultado das metas do colaborador
        [HttpGet]
        [Route("ListMetaResultado")]
        public async Task<ActionResult> GetMetasByUsuarioCicloResult([FromQuery] int ANOCICLO)
        {
            var result = await _applicationServiceColaborador.OnGetFindMetaResult(ANOCICLO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //Lista de resultados das metas emequipes anterriores
        [HttpGet]
        [Route("ListMetaResultadoPrevius")]
        public async Task<ActionResult> GetMetasPreviusByUsuarioCicloResult([FromQuery] int anociclo)
        {
            Metas.Profile.pkxd.type = 1;
            var result = await _applicationServiceColaborador.OnGetFindMetaResult(anociclo);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //Lista de afastamento do colaborador
        [HttpGet]
        [Route("ListRemoval")]
        public async Task<ActionResult> GetAfastamentoByUsuarioCiclo([FromQuery] int CICLLO)
        {
            var result = await _applicationServiceColaborador.OnGetFindAfastamento(CICLLO);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
