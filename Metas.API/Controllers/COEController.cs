using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using DocumentFormat.OpenXml.Wordprocessing;
using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Profile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    public class COEController : Controller
    {

        private readonly IAplicationServiceCOE _applicationServiceCOE;
        public COEController(IAplicationServiceCOE ApplicationServiceCOE)
        {
            this._applicationServiceCOE = ApplicationServiceCOE;
        }

        // LISTA DE FORMULÁRIO
        [HttpGet]
        [Route("ListForm")]
        public async Task<ActionResult> onGetListForm([FromQuery] int IDCELULATRABALHO)
        {
            var result = await _applicationServiceCOE.onGetListForm(IDCELULATRABALHO);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // LISTA UNIDADE OPERACIONAL
        [HttpGet]
        [Route("ListOperatingUnit")]
        public async Task<ActionResult> onListOperatingUnit()
        {
            var result = await _applicationServiceCOE.onListOperatingUnit();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // LISTA DE GESTORES POR UNIDADE OPERACIONAL
        [HttpGet]
        [Route("ListGestor")]
        public async Task<ActionResult> onGetListGestor(int IDUNIDADEOPERACIONAL)
        {
            var result = await _applicationServiceCOE.onGetListGestor(IDUNIDADEOPERACIONAL);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        //LISTA DO CRONOGRAMA APLICADO
        [HttpGet]
        [Route("ListSchedule")]
        public async Task<ActionResult> ListSchedule()
        {
            var result = await _applicationServiceCOE.onListSchedule();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        // ATUALIZA CRONOGRAMA APLICADO
        [HttpPost]
        [Route("SaveSchedule")]
        public async Task<ActionResult> SaveSchedule( CronogramaAplicadoDTO DTO)
        {
            var rng = new Random();
            var forecasts = Enumerable.Range(1, 5).Select(index => new CronogramaAplicadoDTO
            {
                ATIVO = 1,
                DESCRICAO = "saaa",
                IDCRONOGRAMA = 1,
                DATAPROGRAMADA = DateTime.Now.AddDays(index),
            });

            var result = await _applicationServiceCOE.onSaveSchedule(DTO);
            CronogramaAplicadoDTO hh = new CronogramaAplicadoDTO();

            return Ok();

        }

        //SALVAR INDICADOR DE NEGOCIO
        [HttpPost]
        [Route("SaveForm")]
        public async Task<ActionResult> SaveForm(IndicadorNegocioDTO dto)
        {
            var result = await _applicationServiceCOE.OnSaveForm(dto);
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

        // LISTA DE INDICADORES DE NEGOCIO CADASTRADOS P/CÉLULA
        [HttpGet]
        [Route("ListIndicatorAdd")]
        public async Task<ActionResult> GetListIndicatorAdd([FromQuery] int ANOCILO)
        {
            var result = await _applicationServiceCOE.OnGetListIndicatorAdd(ANOCILO);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //BIBLIOTECA DE INDICADORES
        [HttpGet]
        [Route("IndicatorLibrary")]
        public async Task<ActionResult> GetIndicatorLibrary([FromQuery] EIndicatorLibraryDTO DTO)
        {
            var result = await _applicationServiceCOE.OnGetIndicatorLibrary(DTO);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // ADCIONAR INDICADOR DA BIBLIOTECA
        [HttpPost]
        [Route("SaveFormLibrary")]
        public async Task<ActionResult> SaveFormLibrary(EIndicadorSAPDTO dto)
        {
            var result = await _applicationServiceCOE.OnSaveFormLibrary(dto);
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


        [HttpGet]
        [Route("ListAtiv")]
        public async Task<ActionResult> GetListAtiv([FromQuery] EIndicatorLibraryDTO DTO)
        {
           

            return Ok();
        }
    }
}
