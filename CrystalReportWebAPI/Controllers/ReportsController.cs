using CrystalReportWebAPI.Utilities;
using System.Net.Http;
using System.Web.Http;

namespace CrystalReportWebAPI.Controllers
{
    [RoutePrefix("api/Reports")]
    public class ReportsController : ApiController
    {
      

        [AllowAnonymous]
        [Route("Metas")]
        [HttpGet]
        [ClientCacheWithEtag(60)]  //1 min client side caching
                
        public HttpResponseMessage GenerateReportMetas(int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO)
        {
            string reportPath = "~/Reports/Metas";

            string reportFileName = "Metas.rpt";
            string exportFilename = "Metas.pdf";
            string ReportName = "Metas";

            HttpResponseMessage result = CrystalReport.RenderReport(reportPath, reportFileName, exportFilename, ReportName, "PDF", 1, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            return result;
        }

        [AllowAnonymous]
        [Route("SimularMetas")]
        [HttpGet]
        [ClientCacheWithEtag(60)]  //1 min client side caching
        public HttpResponseMessage GenerateReportSimularMetas(int? PR_TIPO, int? PR_RETURN,int? ANOCICLO, int? IDCELULATRABALHO)
        {
            string reportPath = "~/Reports/Metas";
            string reportFileName = "SimularMetas.rpt";
            string exportFilename = "SimularMetas.xls";
            string ReportName = "SimularMetas";

            HttpResponseMessage result = CrystalReport.RenderReport(reportPath, reportFileName, exportFilename, ReportName, "Excel", 3 ,PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO); //  "Excel");  //"PDF");
            return result;
        }


        [AllowAnonymous]
        [Route("SimplesUnidadeMetas")]
        [HttpGet]
        [ClientCacheWithEtag(60)]  //1 min client side caching
        public HttpResponseMessage GenerateReportSimplesUnidadesMetas(int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO)
        {
            string reportPath = "~/Reports/Metas";
            string reportFileName = "SimplesUnidadeMetas.rpt";
            string exportFilename = "SimplesUnidadeMetas.pdf";
            string ReportName = "SimplesUnidadeMetas";

            HttpResponseMessage result = CrystalReport.RenderReport(reportPath, reportFileName, exportFilename, ReportName, "PDF", 3, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            return result;
        }

        [AllowAnonymous]
        [Route("OrientacoesMetas")]
        [HttpGet]
        [ClientCacheWithEtag(60)]  //1 min client side caching
        public HttpResponseMessage GenerateReportOrientacoesMetas(int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO)
        {
            string reportPath = "~/Reports/Metas";
            string reportFileName = "OrientacaoMetas.rpt";
            string exportFilename = "OrientacaoMetas.pdf";
            string ReportName = "OrientacaoMetas";

            HttpResponseMessage result = CrystalReport.RenderReport(reportPath, reportFileName, exportFilename, ReportName, "PDF", 0);
            return result;
        }

        [AllowAnonymous]
        [Route("GestorMetas")]
        [HttpGet]
        [ClientCacheWithEtag(60)]  //1 min client side caching
        public HttpResponseMessage GenerateReportGestorMetas(int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO)
        {
            string reportPath = "~/Reports/Metas";
            string reportFileName = "GestorMetas.rpt";
            string exportFilename = "GestorMetas.pdf";
            string ReportName = "GestorMetas";
            int IdReport = 4;

            HttpResponseMessage result = CrystalReport.RenderReport(reportPath, reportFileName, exportFilename, ReportName, "PDF", IdReport);
            return result;
        }
    }
}