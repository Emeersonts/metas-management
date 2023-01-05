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
    public class RepositoryRepresentante : IRepositoryRepresentante
    {
        async public Task<DataTable> RGetAddSIndicator(int ciclo)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[06];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ciclo;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_APROVAINDICADOR]");

            return ui;
        }

        async public Task<DataTable> RGetGoalsReport(int ciclo, pkxd pkx)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[03];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = pkxd.type;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ciclo;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_METARELATORIO]");

            return ui;
        }

        async public Task<DataTable> RGetListProcess()
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[02];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_PROCESSOSAP]");

            return ui;
        }

        async public Task<DataTable> RGetListsolicitation(SearchcSolicitgacaoDTO dto, int anociclo, int pagina, int npagina)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[12];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

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
            parametro[cont].Value = 0;

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

        async public Task<int> RRemoveIndicador(int IDINDICADOR)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[05];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.function;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@IDINDICADOR", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDINDICADOR;

            ClsData pk = new ClsData();

            var ui = await pk.ExecRunPar(parametro, "[SMetas].[E_INDICADOR]");

            return ui;
        }

        async public Task<int> RSaveIndicador(Indicador indicador)
        {

            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[16];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

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
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDINDICADOR", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.IDINDICADOR;
            
            cont++;
            parametro[cont] = new SqlParameter("@NOME", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.NOME;

            cont++;
            parametro[cont] = new SqlParameter("@DESCRICAOINDICADOR", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.DESCRICAOINDICADOR;

            cont++;
            parametro[cont] = new SqlParameter("@IDUNIDADEMEDIDA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.IDUNIDADEMEDIDA;

            cont++;
            parametro[cont] = new SqlParameter("@IDFREQUENCIA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.IDFREQUENCIA;

            cont++;
            parametro[cont] = new SqlParameter("@PESO", SqlDbType.Decimal);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.PESO;

            cont++;
            parametro[cont] = new SqlParameter("@MINIMO", SqlDbType.Decimal);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.MINIMO;

            cont++;
            parametro[cont] = new SqlParameter("@PLANEJADO", SqlDbType.Decimal);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.PLANEJADO;

            cont++;
            parametro[cont] = new SqlParameter("@DESAFIO", SqlDbType.Decimal);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.DESAFIO;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.ANOCICLO;

            cont++;
            parametro[cont] = new SqlParameter("@MES", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.MES;

            cont++;
            parametro[cont] = new SqlParameter("@APURADO", SqlDbType.Decimal);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.APURADO.Value;

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_INDICADOR]");

            return ui;
        }

        async public Task<int> RSendForApprovalIndicador(int ciclo)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

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
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ciclo;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;
            
            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async public Task<int> RSendResultForApproval(int ANOCICLO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

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
            parametro[cont].Value = 3;

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
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async public Task<int> RSendResultForApprovalJul(int ANOCICLO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[8];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 8;

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
            parametro[cont].Value = 3;

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
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@MENSSAGEM", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_STATUSINDICADOR]");

            return ui;
        }

        async Task<DataTable> IRepositoryRepresentante.RGetFindColaborador(int PAGINA, int QTPAGINA  )
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[07];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

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
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_COLABORADOR]");

            return ui;
        }

        async Task<DataTable> IRepositoryRepresentante.RGetFindIndicatorSAP(SearchcRepresentanteDTO dto)
        {
            int cont = 0;
            
            SqlParameter[] parametro = new SqlParameter[08];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.PAGINA;

            cont++;
            parametro[cont] = new SqlParameter("@IDFREQUENCIA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.IDFREQUENCIA;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@BUSCA", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.BUSCA;
            if (dto.BUSCA == null) {parametro[cont].Value = "";}

            cont++;
            parametro[cont] = new SqlParameter("@INDICADORES", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@MES", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_INDICADORES]");

            return ui;
        }

        async Task<DataTable> IRepositoryRepresentante.RGetListIndicatorAdd(SearchcIndicadorDTO dto, pkxd pkx)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[08];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

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
            parametro[cont] = new SqlParameter("@PAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDFREQUENCIA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@BUSCA", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            cont++;
            parametro[cont] = new SqlParameter("@INDICADORES", SqlDbType.Char);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.INDICADORES;
            if (dto.INDICADORES == null) { parametro[cont].Value = "";}

            cont++;
            parametro[cont] = new SqlParameter("@MES", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.MES;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_INDICADORES]");

            return ui;
        }

        async Task<DataTable> IRepositoryRepresentante.RTimeline()
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
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.user;
            parametro[cont].Value = 1; // PERFIL DO USUÁRIO CADASTRADAO

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_CRONOGRAMA]");

            return ui;
        }
    }
}
