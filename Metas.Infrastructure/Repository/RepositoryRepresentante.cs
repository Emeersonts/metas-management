using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Infrastructure.Interface;
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

            SqlParameter[] parametro = new SqlParameter[05];

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
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = ciclo;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_APROVAINDICADOR]");

            return ui;
        }

        async public Task<DataTable> RGetGoalsReport(int ciclo)
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
            parametro[cont].Value = ciclo;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_METARELATORIO]");

            return ui;
        }

        async public Task<DataTable> RGetListsolicitation(SearchcSolicitgacaoDTO dto)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[08];

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
            //parametro[cont].Value = Metas.Profile.pkxd.user;
            parametro[cont].Value = 1;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@BUSCA", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.BUSCA;

            cont++;
            parametro[cont] = new SqlParameter("ORIGEM", SqlDbType.Bit);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.ORIGEM;

            cont++;
            parametro[cont] = new SqlParameter("@RESPONSAVEL", SqlDbType.Bit);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.RESPONSACAL;

            cont++;
            parametro[cont] = new SqlParameter("@STATUS", SqlDbType.Bit);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.STATUS;

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
            //parametro[cont].Value = Metas.Profile.pkxd.user;
            parametro[cont].Value = 1;

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

            SqlParameter[] parametro = new SqlParameter[14];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.type;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.function;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;

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

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_INDICADOR]");

            return ui;
        }

        async Task<DataTable> IRepositoryRepresentante.RGetFindColaborador(SearchcRepresentanteDTO dto)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[05];

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
            parametro[cont] = new SqlParameter("@NPAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 10;

            cont++;
            parametro[cont] = new SqlParameter("@NPESSOAL", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_COLABORADOR]");

            return ui;
        }

        async Task<DataTable> IRepositoryRepresentante.RGetFindIndicatorSAP(SearchcRepresentanteDTO dto)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[07];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

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
            parametro[cont] = new SqlParameter("@PAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.PAGINA;
            
            cont++;
            parametro[cont] = new SqlParameter("@IDFREQUENCIA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.IDFREQUENCIA;

            cont++;
            parametro[cont] = new SqlParameter("@BUSCA", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = dto.BUSCA;

            cont++;
            parametro[cont] = new SqlParameter("@INDICADORES", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_INDICADORES]");

            return ui;
        }

        async Task<DataTable> IRepositoryRepresentante.RGetListIndicatorAdd(SearchcIndicadorDTO dto)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[07];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
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
            parametro[cont].Value = 1;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_CRONOGRAMA]");

            return ui;
        }
    }
}
