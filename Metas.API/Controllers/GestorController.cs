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
    [Route("[controller]")]

    public class GestorController : Controller
    {
        private readonly IAplcationServiceGestor  _applicationServiceGestor;
        public GestorController(IAplcationServiceGestor ApplicationServigestor)
        {
            this._applicationServiceGestor = ApplicationServigestor;
        }

        // Visualizar equipe
        [HttpPost]
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
    }
}
