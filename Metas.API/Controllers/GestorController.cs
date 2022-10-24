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
        public async Task<ActionResult> GetTeam(int CICLO)
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
        public async Task<ActionResult> GetFormTtype(int CICLO)
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
    }
}
