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
  
    public class RepositoryCiclo : IRepositoryCiclo
    {
        async Task<DataTable> IRepositoryCiclo.RGetFindGetListCiclo()
        {
            SqlParameter[] parametro = new SqlParameter[01];

            int cont = 0;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_CICLO]");

            return ui;
        }

        async Task<DataTable> IRepositoryCiclo.RGetFindGetListProgressStatus(SearchcColaborador dto)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[05];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.type;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 1;
            //parametro[cont].Value = Metas.Profile.pkxd.user;

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

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_STATUSCICLOATRIBUIDO]");

            return ui;

        }
    }
}
