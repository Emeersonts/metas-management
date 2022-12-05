using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Profile;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public async Task<ActionResult> SaveSchedule([FromQuery] CronogramaAplicadoDTO[] dto)
        {

            var result = await _applicationServiceCOE.onSaveSchedule(dto);
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

        //SALVAR INDICADOR DE NEGOCIO
        [HttpPost]
        [Route("SaveForm")]
        public async Task<ActionResult> SaveForm(int IDCELULATRABALHO, GIndicadorDTTO dto, int OPERACAO)
        {

            var result = await _applicationServiceCOE.OnSaveForm(IDCELULATRABALHO, dto, OPERACAO);
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
        public async Task<ActionResult> GetListIndicatorAdd([FromQuery] int IDCELULATRABALHO)
        {
            var result = await _applicationServiceCOE.OnGetListIndicatorAdd(IDCELULATRABALHO);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


    }
}
