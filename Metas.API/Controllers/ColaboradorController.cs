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
    [Route("Colaborador/")]

    public class ColaboradorController : Controller
    {

        private readonly IAplicationServiceColaborador _applicationServiceColaborador;

        public ColaboradorController(IAplicationServiceColaborador ApplicationServiceColaborador)
        {
            this._applicationServiceColaborador = ApplicationServiceColaborador;
        }

        // Lista a meta do colaborador
        [HttpPost]
        [Route("ListMeta")]
        public async Task<ActionResult> GetMetasByUsuarioCiclo(CicloUsuarioDTO dto)
        {
            var result = await _applicationServiceColaborador.OnGetFindMeta(dto); 
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // Lista de Metas equipes anterior
        [HttpPost]
        [Route("ListMetaPrevius")]
        public async Task<ActionResult> GetMetasPreviusByUsuarioCiclo(CicloUsuarioDTO dto)
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
        [HttpPost]
        [Route("ListMetaResultado")]
        public async Task<ActionResult> GetMetasByUsuarioCicloResult(CicloUsuarioDTO dto)
        {
            var result = await _applicationServiceColaborador.OnGetFindMetaResult(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //Lista de resultados das metas emequipes anterriores
        [HttpPost]
        [Route("ListMetaResultadoPrevius")]
        public async Task<ActionResult> GetMetasPreviusByUsuarioCicloResult(CicloUsuarioDTO dto)
        {
            Metas.Profile.pkxd.type = 1;
            var result = await _applicationServiceColaborador.OnGetFindMetaResult(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //Lista de afastamento do colaborador
        [HttpPost]
        [Route("ListRemoval")]
        public async Task<ActionResult> GetAfastamentoByUsuarioCiclo(int CICLLO)
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
