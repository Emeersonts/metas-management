using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Infrastructure.Interface;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Repository
{
    public class RepositoryGestor : IRepositoryGestor
    {
        async public Task<int> RAprovarIndicador(int ANOCICLO, int IDCELULATRABALHO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 5;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@IDNOTIFICACAO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 5; //fixo na notificação

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async public Task<int> RAprovarResults(int ANOCICLO, int IDCELULATRABALHO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 6;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 3;

            cont++;
            parametro[cont] = new SqlParameter("@IDNOTIFICACAO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 6; //fixo na notificação

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async public Task<int> RAprovarResultsJul(int ANOCICLO, int IDCELULATRABALHO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 10;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 3;

            cont++;
            parametro[cont] = new SqlParameter("@IDNOTIFICACAO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 6; //fixo na notificação

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async public Task<DataTable> RGetFindColaborador(int PAGINA, int QTPAGINA, int IDCELULATRABALHO, int ANOCICLO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[07];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = PAGINA;

            cont++;
            parametro[cont] = new SqlParameter("@NPAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = QTPAGINA;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ANOCICLO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_COLABORADOR]");

            return ui;
        }

        async public Task<DataTable> RGetFindMeta(SearchcColaborador dto, pkxd pkx)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[07];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.function;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@MES", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.MES;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.IDCELULATRABALHO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_META]");

            return ui;
        }

        async public Task<DataTable> RGetFindMetaResult(int ANOCICLO, int IDCELULATRABALHO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[06];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.function;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_RESULTADO]");

            return ui;
        }

        async public Task<DataTable> RGetFormTtype(int CICLO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[04];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 3;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = CICLO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_TIPOEDICAOFORMULARIO]");

            return ui;
        }

        async public Task<DataTable> RGetListsolicitation(SearchcSolicitgacaoDTO dto, int anociclo, int pagina, int npagina, int idcelulatrabalho)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[12];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@BUSCA", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.BUSCA;
            if (dto.BUSCA == null) { parametro[cont].Value = ""; }

            cont++;
            parametro[cont] = new SqlParameter("ORIGEM", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.ORIGEM;

            cont++;
            parametro[cont] = new SqlParameter("@RESPONSAVEL", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.RESPONSAVEL;

            cont++;
            parametro[cont] = new SqlParameter("@STATUS", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.STATUS;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = anociclo;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = idcelulatrabalho;

            cont++;
            parametro[cont] = new SqlParameter("@PAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = pagina;

            cont++;
            parametro[cont] = new SqlParameter("@NPAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = npagina;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_SOLICITACAO]");

            return ui;
        }

        async public Task<DataTable> RGetReviewResults(int anociclo, int idcelulatrabalho)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[06];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = anociclo;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = idcelulatrabalho;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_APROVAINDICADOR]");

            return ui;
        }

        async public Task<int> RRequestAdjustmentResult(int ANOCICLO, int IDCELULATRABALHO, string MENSSAGEM)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 3;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@IDNOTIFICACAO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 4; //fixo na notificação

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = MENSSAGEM;

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async public Task<int> RRequestAdjustmentt(int ANOCICLO, int IDCELULATRABALHO,string MENSSAGEM)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 3;

            cont++;
            parametro[cont] = new SqlParameter("@IDNOTIFICACAO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2; //fixo na notificação

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = MENSSAGEM;

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async public Task<int> RSaveFormEditType(TipoEdicaoFormulario tipoedicaoformularo)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[09];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 3;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = tipoedicaoformularo.ANOCICLO;
            
            cont++;
            parametro[cont] = new SqlParameter("@IDTIPOEDICAOFORMULARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = tipoedicaoformularo.IDTIPOEDICAOFORMULARIO;

            cont++;
            parametro[cont] = new SqlParameter("@IDREPRESENTANTE", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = tipoedicaoformularo.IDREPRESENTANTE;

            cont++;
            parametro[cont] = new SqlParameter("@IDSUPLENTE", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = tipoedicaoformularo.IDSUPLENTE;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = tipoedicaoformularo.IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@STATUS", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = tipoedicaoformularo.IDSTATUSCICLO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_TIPOEDICAOFORMULARIO]");

            return ui;

        }

        async public Task<DataTable> RVializeTeam(int CICLO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[04];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 3;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = CICLO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_EQUIPE]");

            return ui;
        }

        async Task<DataTable> IRepositoryGestor.RGetGoalsReport(int CICLO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[03];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = CICLO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_METARELATORIO]");

            return ui;
        }
    }
}
