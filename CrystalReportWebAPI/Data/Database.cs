using CrystalReportWebAPI.Reports.Metas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CrystalReportWebAPI.Data
{
    public class Database
    {

        public DataTable getDataTableFormMetas(string Procedure, int? PR_TIPO = 0, int? PR_RETURN = 0, int? ANOCICLO = 0, int? IDCELULATRABALHO = 0)
        {
            DataTable DT = new DataTable();

            DT.Columns.Add("NOME", typeof(String));
            DT.Columns.Add("DESCRICAOUNBIDADEMEDIA", typeof(String));
            DT.Columns.Add("DESCRICAOFREQUENCIA", typeof(String));
            DT.Columns.Add("MINIMO", typeof(Double));
            DT.Columns.Add("PLANEJADO", typeof(Double));
            DT.Columns.Add("DESAFIO", typeof(Double));
            DT.Columns.Add("RESULTADO", typeof(Double));
            DT.Columns.Add("APURADO", typeof(Double));
            DT.Columns.Add("MES", typeof(String));

            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 25, 75, "95", 100, null, "Janeiro" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 30, 75, "95", 100, null, "Fevereiro" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 40, 75, "95", 100, null, "Março" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 10, 75, "95", 100, null, "Abril" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 15, 75, "95", 100, null, "Maio" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 20, 75, "95", 100, null, "Junho" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 15, 75, "95", 100, null, "Julho" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 12, 75, "95", 100, null, "Agosto" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 18, 75, "95", 100, null, "Setembro" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 24, 75, "95", 100, null, "Outubro"});
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 35, 75, "95", 100, null, "Novembro" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 60, 75, "95", 100, null, "Dezembro" });

            //DT.WriteXml("C:\\Projects\\CrystalReportWebAPI-master\\CrystalReportWebAPI\\Reports\\ReportData\\Metas.xml");
            DT.TableName = "Metas";

            return DT;
        }

        public DataTable getDataTableFormSimulaMetas(int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO, string Procedure)
        {
            DataTable DT = new DataTable();

            DT.Columns.Add("NP", typeof(int));
            DT.Columns.Add("NomeCompleto", typeof(String));
            DT.Columns.Add("Cargo", typeof(String));
            DT.Columns.Add("Subgrupo", typeof(String));
            DT.Columns.Add("DatadeAdmissao", typeof(DateTime));
            DT.Columns.Add("DatadeDemissao", typeof(DateTime));
            DT.Columns.Add("AreadeRH", typeof(string));
            DT.Columns.Add("EGU", typeof(double));
            DT.Columns.Add("ON", typeof(double));
            DT.Columns.Add("CodigodaUO", typeof(double));
            DT.Columns.Add("DescriçaodaUO", typeof(String));
            DT.Columns.Add("GestorAtual", typeof(String));
            DT.Columns.Add("Pais", typeof(String));

            DT.Rows.Add(new object[] { "0000", "Colaborador 1", "Lorem Ipsum","Lorem Ipsum","01/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            DT.Rows.Add(new object[] { "0000", "Colaborador 2", "Lorem Ipsum","Lorem Ipsum","02/10/2022","01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            DT.Rows.Add(new object[] { "0000", "Colaborador 3", "Lorem Ipsum","Lorem Ipsum","03/10/2022","01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            DT.Rows.Add(new object[] { "0000", "Colaborador 4", "Lorem Ipsum","Lorem Ipsum","04/10/2022","01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            DT.Rows.Add(new object[] { "0000", "Colaborador 5", "Lorem Ipsum","Lorem Ipsum","05/10/2022","01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            DT.Rows.Add(new object[] { "0000", "Colaborador 6", "Lorem Ipsum","Lorem Ipsum","06/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });



            //DT.WriteXml("C:\\Projects\\CrystalReportWebAPI-master\\CrystalReportWebAPI\\Reports\\ReportData\\Metas.xml");
            DT.TableName = "SimularMetas";

            return DT;
        }
        public DataTable getDataTableFormOrientacaoMetas()
            //(String Paragraph1, String Title1, String ParagraphTitle1, String Title2, String ParagraphTitle2, String Title3, String ParagraphTitle3, String Title4, String ParagraphTitle4, String Title5, String ParagraphTitle5, String Title6, String ParagraphTitle6)
        {

            DataTable DT = new DataTable();

            DT.Columns.Add("Paragrafo1", typeof(String));
            DT.Columns.Add("Titulo1", typeof(String));
            DT.Columns.Add("TextoTitulo1", typeof(String));
            DT.Columns.Add("Titulo2", typeof(String));
            DT.Columns.Add("TextoTitulo2", typeof(String));
            DT.Columns.Add("Titulo3", typeof(String));
            DT.Columns.Add("TextoTitulo3", typeof(String));
            DT.Columns.Add("Titulo4", typeof(String));
            DT.Columns.Add("TextoTitulo4", typeof(String));
            DT.Columns.Add("Titulo5", typeof(String));
            DT.Columns.Add("TextoTitulo5", typeof(String));
            DT.Columns.Add("Titulo6", typeof(String));
            DT.Columns.Add("TextoTitulo6", typeof(String));


            DT.Rows.Add(new object[] { "Lorem ipsum dolor sit amet. Os operadores gráficos e tipográficos sabem disso bem, na realidade, todas as profissões que lidam com o universo da comunicação têm um relacionamento estável com essas palavras, mas o que é? Lorem ipsum é um texto sem qualquer sentido.", "1. Tiíulo 1 ", "É uma seqüência de palavras latinas que, como estão posicionadas, não formem frases com um sentido completo, mas dão vida a um texto de teste útil para preencher espaços que irão Posteriormente serão ocupados a partir de textos ad hoc compostos por profissionais de comunicação.", "2. Título 2", "É certamente o texto de marcador de posição mais famoso , mesmo que existam diferentes versões distinguíveis da ordem em que as palavras latinas são repetidas. Lorem ipsum contém as tipos de letra mais em uso, um aspecto que permite que você tenha uma visão geral da renderização do texto em termos de escolha da fonte e tamanho da fonte.", "3. Título 3", "Ao se referir a Lorem ipsum, diferentes expressões são usadas, nomeadamente texto de preenchimento , texto fictício , texto cego ou texto do espaço reservado: em suma, seu significado também pode ser zero, mas sua utilidade é tão clara quanto ao longo dos séculos e resiste às versões irônicas e modernas que vieram com a chegada da web.", "4. Título 4", "« Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. »", "5. Título 5", "O texto de preenchimento Lorem ipum é utilizado por designers gráficos, programadores e impressoras com o objetivo de ocupar os espaços de um site, um produto publicitário ou uma produção editorial cujo texto final ainda não está pronto.", "6. Título 6", "Para ter um resultado que está de acordo com o resultado final, os designers gráficos, designers ou tipógrafos informam o texto de Lorem ipsum em relação a dois aspectos fundamentais, a saber, a legibilidade e os requisitos editoriais." });
            
            DT.TableName = "OrientacaoMetas";

            return DT;
        }
        public DataTable getDataTableFormSimplesUnidadeMetas(int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO, string Procedure)
        {

            DataTable DT = new DataTable();
            DT.Columns.Add("CODFORM", typeof(String));
            DT.Columns.Add("DESCRICAO", typeof(String));
            DT.Columns.Add("ATA", typeof(String));
            DT.Columns.Add("REPRESENTANTE", typeof(String));
            DT.Columns.Add("NPrepresentante", typeof(String));
            DT.Columns.Add("SUPLENTE", typeof(String));
            DT.Columns.Add("NPsuplente", typeof(String));
            DT.Columns.Add("GESTOR", typeof(String));
            DT.Columns.Add("NPGestor", typeof(String));
            DT.Columns.Add("STATUS", typeof(String));
            DT.Columns.Add("IDINDICADOR", typeof(String));
            DT.Columns.Add("NOME", typeof(String));
            DT.Columns.Add("PESO", typeof(String));
            DT.Columns.Add("IDFREQUENCIA", typeof(String));
            DT.Columns.Add("NOMEFREQUENCIA", typeof(String));
            DT.Columns.Add("IDUNIDADEMEDIDA", typeof(String));
            DT.Columns.Add("DESCUNIDADEMEDIDA", typeof(String));
            DT.Columns.Add("MES", typeof(String));
            DT.Columns.Add("MINIMO", typeof(String));
            DT.Columns.Add("DESAFIO", typeof(String));
            DT.Columns.Add("PLANEJADO", typeof(String));
            DT.Columns.Add("RESULTADO", typeof(String));
            DT.Columns.Add("IDRESULTADOCICLO", typeof(String));
            DT.Columns.Add("MES1", typeof(String));
            DT.Columns.Add("DESCRICAO1", typeof(String));
            DT.Columns.Add("APURADO", typeof(String));


           
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 1 ", "  1,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  1 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente"," Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 2 ", "  2,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  2 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente"," Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 3 ", "  3,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  3 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente"," Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 4 ", "  4,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  4 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 5 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  5 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 6 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  6 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 7 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  7 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 8 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  8 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 9 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  9 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 10 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  10 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 11 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  11 ", "  Total 1º semestre ", "  -0,9996 " });
            DT.Rows.Add(new object[] { "06d5b5db-8603-1eeb-9892-8723b96adb60", " Primeiro formuário", " OK ", " Nome representante ", "NPrepresentante", " Suplente", "NPsuplente", "Nome tres", "NPGestor", "OK", "  2022 ", "   AA5 ", "1 ", "  1 ", "  Mensal ", " 1 ", "percentual ", " 12 ", "  5,0000 ", " 5,0000 ", " 4,0000 ", " 0,0000 ", " 6 ", "  12 ", "  Total 1º semestre ", "  -0,9996 " });



            //DT.Rows.Add(new object[] { "0000", "Colaborador 1", "Lorem Ipsum", "Lorem Ipsum", "01/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            //DT.Rows.Add(new object[] { "0000", "Colaborador 2", "Lorem Ipsum", "Lorem Ipsum", "02/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            //DT.Rows.Add(new object[] { "0000", "Colaborador 3", "Lorem Ipsum", "Lorem Ipsum", "03/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            //DT.Rows.Add(new object[] { "0000", "Colaborador 4", "Lorem Ipsum", "Lorem Ipsum", "04/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            //DT.Rows.Add(new object[] { "0000", "Colaborador 5", "Lorem Ipsum", "Lorem Ipsum", "05/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });
            //DT.Rows.Add(new object[] { "0000", "Colaborador 6", "Lorem Ipsum", "Lorem Ipsum", "06/10/2022", "01/10/2022", "Lorem Ipsum", 00000, 00000, 00000, "Lorem Ipsum", "Gestor 1 ", "Brasil" });



            //DT.WriteXml("C:\\Projects\\CrystalReportWebAPI-master\\CrystalReportWebAPI\\Reports\\ReportData\\Metas.xml");
            DT.TableName = "SimplesUnidadeMetas";

            return DT;
        }


        public DataTable getDataFormMetas(string Procedure, int? PR_TIPO, int? PR_RETURN, int? ANOCICLO,int? IDCELULATRABALHO)
        {

            SqlConnection conn = new SqlConnection(Connection.conexao);
            SqlDataAdapter DA = new SqlDataAdapter(Procedure, conn);
            DataTable DT = new DataTable();


            DA.SelectCommand.Parameters.AddWithValue("@PR_TIPO", PR_TIPO);
            DA.SelectCommand.Parameters.AddWithValue("@PR_RETURN", PR_RETURN);
            DA.SelectCommand.Parameters.AddWithValue("@ANOCICLO", ANOCICLO);
            DA.SelectCommand.Parameters.AddWithValue("@IDCELULATRABALHO", IDCELULATRABALHO);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            conn.Close();
            conn.Open();
            DA.Fill(DT);
            string sortColumn = "MES";
            DT.DefaultView.Sort = sortColumn.ToString();
            DT = DT.DefaultView.ToTable();

            DT.TableName = "Metas";

            conn.Close();
            return DT;

        }

        public DataTable getDataFormSimularMetas(string Procedure, int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO)
        {

            SqlConnection conn = new SqlConnection(Connection.conexao);
            SqlDataAdapter DA = new SqlDataAdapter(Procedure, conn);
            DataTable DT = new DataTable();


            DA.SelectCommand.Parameters.AddWithValue("@PR_TIPO", PR_TIPO);
            DA.SelectCommand.Parameters.AddWithValue("@PR_RETURN", PR_RETURN);
            DA.SelectCommand.Parameters.AddWithValue("@ANOCICLO", ANOCICLO);
            DA.SelectCommand.Parameters.AddWithValue("@IDCELULATRABALHO", IDCELULATRABALHO);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            conn.Close();
            conn.Open();
            DA.Fill(DT);
            string sortColumn = "IDINDICADOR, MES";
            string filtro = "IDINDICADOR = " + ANOCICLO;
            DT.DefaultView.Sort = sortColumn.ToString();
            DT.DefaultView.RowFilter = filtro;
            DT = DT.DefaultView.ToTable();

        
            DT.TableName = "SimularMetas";

            conn.Close();
            return DT;

        }

        public DataTable getDataFormSimplesUnidadeMetas(int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO, string Procedure)
        {

            SqlConnection conn = new SqlConnection(Connection.conexao);
            SqlDataAdapter DA = new SqlDataAdapter(Procedure, conn);
            DataTable DT = new DataTable();


            DA.SelectCommand.Parameters.AddWithValue("@PR_TIPO", PR_TIPO);
            DA.SelectCommand.Parameters.AddWithValue("@PR_RETURN", PR_RETURN);
            DA.SelectCommand.Parameters.AddWithValue("@ANOCICLO", ANOCICLO);
            DA.SelectCommand.Parameters.AddWithValue("@IDCELULATRABALHO", IDCELULATRABALHO);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            conn.Close();
            conn.Open();
            DA.Fill(DT);
            string sortColumn = "IDINDICADOR, MES";
            string filtro = "IDINDICADOR = " + ANOCICLO;
            DT.DefaultView.Sort = sortColumn.ToString();
            DT.DefaultView.RowFilter = filtro;
            DT = DT.DefaultView.ToTable();

            DT.TableName = "SimplesUnidadeMetas";

            conn.Close();
            return DT;

        }

        public DataTable getDataFormGestorMetas(int? PR_TIPO, int? PR_IDUSUARIO, int? ANOCICLO,  string Procedure)
        {

            SqlConnection conn = new SqlConnection(Connection.conexao);
            SqlDataAdapter DA = new SqlDataAdapter(Procedure, conn);
            DataTable DT = new DataTable();

           

            DA.SelectCommand.Parameters.AddWithValue("@PR_TIPO", PR_TIPO);
            DA.SelectCommand.Parameters.AddWithValue("@PR_IDUSUARIO", PR_IDUSUARIO);
            DA.SelectCommand.Parameters.AddWithValue("@ANOCICLO", ANOCICLO);
            
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            conn.Close();
            conn.Open();
            DA.Fill(DT);
            string sortColumn = "IDINDICADOR, MES";
            string filtro = "IDINDICADOR = " + ANOCICLO;
            DT.DefaultView.Sort = sortColumn.ToString();
            DT.DefaultView.RowFilter = filtro;
            DT = DT.DefaultView.ToTable();

            DT.TableName = "GestorMetas";

            conn.Close();
            return DT;

        }

        public DataTable getDataTableConfigReports()
        {

            DataTable DT = new DataTable();

            DT.Columns.Add("Procedure", typeof(String));
            DT.Columns.Add("ReportPath", typeof(String));
            DT.Columns.Add("ReportName", typeof(String));
            DT.Columns.Add("Method", typeof(String));
            DT.Columns.Add("IdReport", typeof(int));

            //System.Reflection.Assembly.GetExecutingAssembly().Location


            //System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)

            //string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Reports\\ReportData\\";

            string path = "C:\\GERDAU\\metas-system-management\\CrystalReportWebAPI\\Reports\\ReportData\\";

            DT.Rows.Add(new object[] { "[SMetas].[R_META]", path , "Metas", "getDataFormMetas" ,1});
            DT.Rows.Add(new object[] { "[SMetas].[R_SIMULAR]", path, "SimularMetas", "getDataFormSimularMetas", 2 });
            DT.Rows.Add(new object[] { "[SMetas].[R_SIMULAR]", path,  "SimplesUnidadeMetas", "getDataTableFormSimplesUnidadeMetas", 3 }); // getDataTableFormSimplesUnidadeMetas getDataFormSimplesUnidadeMetas
            DT.Rows.Add(new object[] { "[SMetas].[R_SIMULAR]", path, "OrientacaoMetas", "getDataTableFormOrientacaoMetas", 0 });
            DT.Rows.Add(new object[] { "[SMetas].[R_ATA]", path, "GestorMetas", "getDataTableFormGestorMetas", 4 });
            DT.Rows.Add(new object[] { "[SMetas].[R_ATA]", path, "GestorMetasAgrupa", "getDataTableFormGestorMetasAgrupa", 4 });
            
            return DT;
        }
        public DataTable getDataTableFormGestorMetas(string Procedure, int? PR_TIPO = 0, int? PR_RETURN = 0, int? ANOCICLO = 0, int? IDCELULATRABALHO = 0)
        {
            DataTable DT = new DataTable();

            DT.Columns.Add("NOME", typeof(String));
            DT.Columns.Add("DESCRICAOUNBIDADEMEDIA", typeof(String));
            DT.Columns.Add("DESCRICAOFREQUENCIA", typeof(String));
            DT.Columns.Add("PESO", typeof(Double));
            DT.Columns.Add("MINIMO", typeof(Double));
            DT.Columns.Add("PLANEJADO", typeof(Double));
            DT.Columns.Add("DESAFIO", typeof(Double));
            DT.Columns.Add("MES", typeof(String));

            

            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 25, 75, "95", 100,"1" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 30, 75, "95", 100,"2" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 40, 75, "95", 100,"3" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 10, 75, "95", 100,"4" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 15, 75, "95", 100,"5" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 20, 75, "95", 100,"6" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 15, 75, "95", 100,"7" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 12, 75, "95", 100,"8" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 18, 75, "95", 100,"9" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 24, 75, "95", 100,"10" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 35, 75, "95", 100,"11" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 60, 75, "95", 100,"12" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 25, 75, "90", 100, "1" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 30, 75, "85", 100, "2" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 40, 75, "79", 100, "3" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 10, 75, "84", 100, "4" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 15, 75, "86", 100, "5" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 20, 75, "98", 100, "6" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 15, 75, "99", 100, "7" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 12, 75, "35", 100, "8" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 18, 75, "87", 100, "9" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 24, 75, "74", 100, "10" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 35, 75, "48", 100, "11" });
            DT.Rows.Add(new object[] { "EBTIDA", "Mensal", "%", 60, 75, "95", 100, "12" });


            DT.TableName = "GestorMetas";

            return DT;
        }

        public DataTable getDataTableFormGestorMetasAgrupa(string Procedure, int? PR_TIPO = 0, int? PR_RETURN = 0, int? ANOCICLO = 0, int? IDCELULATRABALHO = 0)
        {
            DataTable DT = new DataTable();


            DT.Columns.Add("MES", typeof(String));



            DT.Rows.Add(new object[] {  "1" });
            DT.Rows.Add(new object[] {  "2" });
            DT.Rows.Add(new object[] {  "3" });
            DT.Rows.Add(new object[] {  "4" });
            DT.Rows.Add(new object[] {  "5" });
            DT.Rows.Add(new object[] {  "6" });
            DT.Rows.Add(new object[] {  "7" });
            DT.Rows.Add(new object[] {  "8" });
            DT.Rows.Add(new object[] {  "9" });
            DT.Rows.Add(new object[] {  "10" });
            DT.Rows.Add(new object[] {  "11" });
            DT.Rows.Add(new object[] {  "12" });
           


            DT.TableName = "GestorMetasAgrupa";

            return DT;
        }


        public DataTable SelectDataReport(string Procedure, string Method, int? PR_TIPO = 0, int? PR_RETURN = 0, int? ANOCICLO = 0, int? IDCELULATRABALHO = 0)
        {
            DataTable DT = new DataTable();

            if (Method == "getDataTableFormMetas")
            {
                DT =  getDataTableFormMetas(Procedure, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO );
            }
            if (Method == "getDataFormMetas")
            {
                DT = getDataFormMetas(Procedure, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }

            if (Method == "getDataFormSimularMetas")
            {
                DT = getDataFormSimularMetas(Procedure, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }
            if (Method == "getDataTableFormSimulaMetas")
            {
                DT = getDataTableFormSimulaMetas(PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO, Procedure);
            }
            if (Method == "getDataFormSimplesUnidadeMetas")
            {
                DT = getDataFormSimplesUnidadeMetas(PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO, Procedure);
            }
            if (Method == "getDataTableFormSimplesUnidadeMetas")
            {
                DT = getDataTableFormSimplesUnidadeMetas(PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO, Procedure);
            }
            

            if (Method == "getDataTableFormOrientacaoMetas")
            {
                DT = getDataTableFormOrientacaoMetas();
            }
            if (Method == "getDataTableFormGestorMetas")
            {
                DT = getDataTableFormGestorMetas(Procedure, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }
            if (Method == "getDataTableFormGestorMetasAgrupa")
            {
                DT = getDataTableFormGestorMetasAgrupa(Procedure, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }



            return DT;
        }

        public DataTable SelectDataReportRegular(string Procedure, string Method, int? PR_TIPO, int? PR_RETURN, int? ANOCICLO, int? IDCELULATRABALHO)
        {
            DataTable DT = new DataTable();

            if (Method == "getDataTableFormMetas")
            {
                DT = getDataTableFormMetas(Procedure,PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }
            if (Method == "getDataFormMetas")
            {
                DT = getDataFormMetas(Procedure, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }

            if (Method == "getDataFormSimularMetas")
            {
                DT = getDataFormSimularMetas(Procedure, PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO);
            }
            if (Method == "getDataTableFormSimulaMetas")
            {
                DT = getDataTableFormSimulaMetas(PR_TIPO, PR_RETURN, ANOCICLO, IDCELULATRABALHO, Procedure);
            }

            return DT;
        }


    }
}
