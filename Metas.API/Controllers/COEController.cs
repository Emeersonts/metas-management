using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using DocumentFormat.OpenXml.Wordprocessing;
using FastReport.Web;
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


using System.IO;
using Path = System.IO.Path;
using FastReport.Export.PdfSimple;
using FastReport.Data;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using FastReport.Utils;

namespace Metas.API.Controllers
{
    public class COEController : Controller
    {

        private readonly IAplicationServiceCOE _applicationServiceCOE;

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _config;

        public COEController(IAplicationServiceCOE ApplicationServiceCOE, IWebHostEnvironment webHostEnvironment, IConfiguration config)
        {
            this._applicationServiceCOE = ApplicationServiceCOE;
            this._webHostEnvironment = webHostEnvironment;
            this._config = config;
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
        public async Task<ActionResult> SaveSchedule(CronogramaAplicadoDTO DTO)
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
        //Gerar Relatorio Metas
        [HttpGet]
        [Route("ReportMetas")]
        public async Task<ActionResult> GenerateReport(int PR_TIPO, int PR_RETURN, int ANOCICLO, int IDCELULATRABALHO)
        {
            try
            {
                var result = "Erro na conexao banco de dados";
                
                RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));

                var mssqlDataConnection = new MsSqlDataConnection();

                if (mssqlDataConnection == null)
                {
                    return Ok(result);
                }

                result = "Erro de leitura WebReport";

                var webReport = new WebReport();
                
                if (webReport == null)
                {
                    return Ok(result);
                    //teste
                }

                webReport.Report.Load(Path.Combine(_webHostEnvironment.ContentRootPath, "Reports", "Metas.frx"));

                mssqlDataConnection.ConnectionString = _config.GetConnectionString("DefaultConnection");
                //definimos os valores para os parâmetros usados         
                var conn = mssqlDataConnection.ConnectionString;

                if (conn == null)
                {
                    result = "Erro de Connectionstring";
                    return Ok(result);
                }


                webReport.Report.SetParameterValue("Conn", conn);
                webReport.Report.SetParameterValue("PR_TIPO", PR_TIPO);
                webReport.Report.SetParameterValue("PR_RETURN", PR_RETURN);
                webReport.Report.SetParameterValue("ANOCICLO", ANOCICLO);
                webReport.Report.SetParameterValue("IDCELULATRABALHO", IDCELULATRABALHO);
                webReport.Report.Prepare();

                using MemoryStream stream = new MemoryStream();
                webReport.Report.Export(new PDFSimpleExport(), stream);

                stream.Flush();
                byte[] arrayReport = stream.ToArray();


                return File(arrayReport, "application/zip", "MetassReport.pdf");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("ReportSimularMetas")]
        public async Task<ActionResult> GenerateReportSimularMetas(int PR_TIPO, int PR_RETURN, int ANOCICLO, int IDCELULATRABALHO)
        {
            try
            {

                var MsSqlDataConnection = new MsSqlDataConnection();

                var mssqlDataConnection = new MsSqlDataConnection();

                var webReport = new WebReport();

                webReport.Report.Load(Path.Combine(_webHostEnvironment.ContentRootPath, "Reports", "SimularMetas.frx"));

                mssqlDataConnection.ConnectionString = _config.GetConnectionString("DefaultConnection");
                //definimos os valores para os parâmetros usados         
                var conn = mssqlDataConnection.ConnectionString;
                webReport.Report.SetParameterValue("Conn", conn);
                webReport.Report.SetParameterValue("PR_TIPO", PR_TIPO);
                webReport.Report.SetParameterValue("PR_RETURN", PR_RETURN);
                webReport.Report.SetParameterValue("ANOCICLO", ANOCICLO);
                webReport.Report.SetParameterValue("IDCELULATRABALHO", IDCELULATRABALHO);
                webReport.Report.Prepare();

                using MemoryStream stream = new MemoryStream();
                webReport.Report.Export(new PDFSimpleExport(), stream);

                stream.Flush();
                byte[] arrayReport = stream.ToArray();


                return File(arrayReport, "application/zip", "SimularMetas.pdf");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("ReportSimplesUnidadeMetas")]
        public async Task<ActionResult> GenerateReportSimplesMetas(int PR_TIPO, int PR_RETURN, int ANOCICLO, int IDCELULATRABALHO)
        {
            try
            {

                var MsSqlDataConnection = new MsSqlDataConnection();

                var mssqlDataConnection = new MsSqlDataConnection();

                var webReport = new WebReport();

                webReport.Report.Load(Path.Combine(_webHostEnvironment.ContentRootPath, "Reports", "SimplesUnidadeMetas.frx"));

                mssqlDataConnection.ConnectionString = _config.GetConnectionString("DefaultConnection");
                //definimos os valores para os parâmetros usados         
                var conn = mssqlDataConnection.ConnectionString;
                webReport.Report.SetParameterValue("Conn", conn);
                webReport.Report.SetParameterValue("PR_TIPO", PR_TIPO);
                webReport.Report.SetParameterValue("PR_RETURN", PR_RETURN);
                webReport.Report.SetParameterValue("ANOCICLO", ANOCICLO);
                webReport.Report.SetParameterValue("IDCELULATRABALHO", IDCELULATRABALHO);
                webReport.Report.Prepare();

                using MemoryStream stream = new MemoryStream();
                webReport.Report.Export(new PDFSimpleExport(), stream);

                stream.Flush();
                byte[] arrayReport = stream.ToArray();


                return File(arrayReport, "application/zip", "SimplesUnidadeMetas.pdf");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("ReportOrientacoesMetas")]
        [HttpGet]
        public async Task<ActionResult> GenerateReportOrientacoesMetas(int PR_TIPO, int PR_RETURN, int ANOCICLO, int IDCELULATRABALHO)
        {
            try
            {

                var MsSqlDataConnection = new MsSqlDataConnection();

                var mssqlDataConnection = new MsSqlDataConnection();

                var webReport = new WebReport();

                webReport.Report.Load(Path.Combine(_webHostEnvironment.ContentRootPath, "Reports", "OrientacaoMetas.frx"));

                mssqlDataConnection.ConnectionString = _config.GetConnectionString("DefaultConnection");
                //definimos os valores para os parâmetros usados         
                var conn = mssqlDataConnection.ConnectionString;
                webReport.Report.SetParameterValue("Conn", conn);
                webReport.Report.SetParameterValue("PR_TIPO", PR_TIPO);
                webReport.Report.SetParameterValue("PR_RETURN", PR_RETURN);
                webReport.Report.SetParameterValue("ANOCICLO", ANOCICLO);
                webReport.Report.SetParameterValue("IDCELULATRABALHO", IDCELULATRABALHO);
                webReport.Report.Prepare();

                using MemoryStream stream = new MemoryStream();
                webReport.Report.Export(new PDFSimpleExport(), stream);

                stream.Flush();
                byte[] arrayReport = stream.ToArray();


                return File(arrayReport, "application/zip", "OrientacaoMetas.pdf");
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
