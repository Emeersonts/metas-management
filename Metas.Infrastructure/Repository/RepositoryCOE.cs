using Metas.Domain;
using Metas.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Repository
{
    public class RepositoryCOE : IRepositoryCOE
    {
        async public Task<DataTable> RGetListForm(int IDCELULATRABALHO)
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
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_FORMULARIOMETA]");

            return ui;

        }

        async public Task<DataTable> RGetListGestor(int IDUNIDADEOPERACIONAL)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[09];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 2;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@NPAGINA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@ANOCICLO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@BUSCA", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = "";

            cont++;
            parametro[cont] = new SqlParameter("@IDUNIDADEOPERACIONAL", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDUNIDADEOPERACIONAL;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_GESTOR]");

            return ui;
        }

        async public Task<DataTable> RGetListIndicatorAdd(int IDCELULATRABALHO)
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
            parametro[cont] = new SqlParameter("IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_INDICADORNEGOCIO]");

            return ui;

        }

        async public Task<DataTable> RGetListSchedule()
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

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_CRONOGRAMAAPLICADO]");

            return ui;
        }

        async public Task<DataTable> RListOperatingUnit()
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

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_UNIDADEOPERACIONAL]");

            return ui;

        }

        async public Task<int> RSaveIndicador(int IDCELULATRABALHO, Indicador indicador, int OPERACAO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[17];

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
            parametro[cont].Value = 5;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@IDINDICADOR", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.IDINDICADOR;

            cont++;
            parametro[cont] = new SqlParameter("@IDCELULATRABALHO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = IDCELULATRABALHO;

            cont++;
            parametro[cont] = new SqlParameter("@OPNEG", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = OPERACAO;

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
            parametro[cont] = new SqlParameter("@APURADO", SqlDbType.Decimal);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = indicador.APURADO;

            ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_INDICADORNEGOCIO]");

            return ui;
        }
    }
}
