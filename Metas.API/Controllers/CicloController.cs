using Metas.Application.DTO;
using Metas.Application.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CicloController : Controller
    {
        private readonly IAplicationServiceCiclo _applicationServiceCiclo;
        public CicloController(IAplicationServiceCiclo ApplicationServiceCiclo)
        {
            this._applicationServiceCiclo = ApplicationServiceCiclo;
        }

        // Lista o progresso do status de um ciclo
        [HttpPost]
        [Route("ListProgressStatus")]
        public async Task<ActionResult> GetListProgressStatus (int CICLO)
        {

            var result = await _applicationServiceCiclo.OnGetListProgressStatus(CICLO); 
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //Lista dos anos(Ciclos)
        [EnableCors("CorsPolicy")]
        [HttpGet]
        [Route("ListCiclo")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Endpoint para preparar para aprovação")]
        public async Task<ActionResult> GetListCiclo()
        {
            var result = await _applicationServiceCiclo.OnGetListCiclo();
            
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
