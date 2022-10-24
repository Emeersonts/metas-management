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
    public class RepositoryGestor : IRepositoryGestor
    {
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
            parametro[cont] = new SqlParameter("@MESTRANFERENCIA", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = tipoedicaoformularo.MESTRANFERENCIA;

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
