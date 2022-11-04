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
    public class RepositoryRH : IRepositoryRH
    {
        public async Task<DataTable> RGetListGestor()
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[03];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 4;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_GESTOR]");

            return ui;

        }
    }
}
