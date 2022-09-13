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
    }
}
