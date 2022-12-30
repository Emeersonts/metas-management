using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Xml.Linq;
using Database = CrystalReportWebAPI.Data.Database;


namespace CrystalReportWebAPI.Utilities
{
    public static class CrystalReport
    {
        //public void MyMethod(string astring, int? anint)
        //{
        //    //some code in which I may have an int to work with
        //    //or I may not...
        //}

        public static HttpResponseMessage RenderReport(string reportPath, string reportFileName, string exportFilename, string ReportName, string TypeFormat, int IdReport, int? PR_TIPO = 0, int? PR_RETURN = 0, int? ANOCICLO = 0, int? IDCELULATRABALHO = 0)
        {
            //public async Task<HttpResponseMessage> GetProduct([FromUri] string param1 = null, [FromUri] string param2 = null, Guid? id = null)
            Database dal = new Database();
            DataTable DT = dal.getDataTableConfigReports();
            DataRow[] foundRows = DT.Select("IdReport = '" + IdReport + "'");

            for (int i = 0; foundRows.Length > i; i++)
            {
                PopulateReport(foundRows[i]["Procedure"].ToString(), foundRows[i]["ReportPath"].ToString(), foundRows[i]["ReportName"].ToString() , foundRows[i]["Method"].ToString(), PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }
  

            var rd = new ReportDocument();

            rd.Load(Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath(reportPath), reportFileName));
            MemoryStream ms = new MemoryStream();

            var result = new HttpResponseMessage(HttpStatusCode.OK);

            if (TypeFormat == "Excel")
            {


                using (var stream = rd.ExportToStream(ExportFormatType.Excel))
                {
                    stream.CopyTo(ms);
                }
                result = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(ms.ToArray())
                };
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
                    {
                        FileName = exportFilename
                    };


                result.Content.Headers.ContentType =
                    new System.Net.Http.Headers.MediaTypeHeaderValue("application/xls");

            }

            if (TypeFormat == "PDF")
            {
                using (var stream = rd.ExportToStream(ExportFormatType.PortableDocFormat))
                {
                    stream.CopyTo(ms);
                }
               result = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(ms.ToArray())
                };
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
                    {
                        FileName = exportFilename
                    };


                result.Content.Headers.ContentType =
                    new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");

            }




            return result;
        }

        public static void PopulateReport(string Procedure, string ReportPath, string ReportName, string Method, int? PR_TIPO = 0, int? PR_RETURN = 0, int? ANOCICLO = 0, int? IDCELULATRABALHO = 0)
        {
            Database dal = new Database();

            DataTable DT = dal.SelectDataReport(Procedure, Method, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);

            ToXmlDocument(DT, ReportName, ReportPath + ReportName +".xml");

        }
        public static XDocument ToXmlDocument(this DataTable dataTable, string rootName, string XmlData)
        {
            var XmlDocument = new XDocument
            {
                Declaration = new XDeclaration("1.0", "utf-8", "")
            };
            XmlDocument.Add(new XElement(rootName));
            foreach (DataRow row in dataTable.Rows)
            {
                XElement element = null;
                if (dataTable.TableName != null)
                {
                    element = new XElement(dataTable.TableName);
                }
                foreach (DataColumn column in dataTable.Columns)
                {
                    element.Add(new XElement(column.ColumnName, row[column].ToString().Trim(' ')));
                }
                if (XmlDocument.Root != null) XmlDocument.Root.Add(element);
            }
            
            // Create the XmlDocument.

            //using (FileStream fs = new FileStream(@"C:\Projects\CrystalReportWebAPI-master\CrystalReportWebAPI\Reports\ReportData\Metas.xml", FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            using (FileStream fs = new FileStream(XmlData, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {
                fs.SetLength(0);
                XmlDocument.Save(fs);
            }

           
            return XmlDocument;
        }
    }

}