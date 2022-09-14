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
    //[Route("Ciclo/")]
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
        public async Task<ActionResult> GetListProgressStatus (CicloUsuarioDTO dto)
        {
            var result = await _applicationServiceCiclo.OnGetListProgressStatus(dto); 
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //Lista dos anos(Ciclos)
        [HttpGet]
        [Route("ListCiclo")]
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
