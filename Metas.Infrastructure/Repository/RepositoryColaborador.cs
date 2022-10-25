using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Infrastructure.Interface;
using Metas.Profile;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
namespace Metas.Infrastructure.Repository
{
    public class RepositoryColaborador : IRepositoryColaborador
    {
        async Task<DataTable> IRepositoryColaborador.RGetFindAfastamento(int CICLO)
        {
            
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[05];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

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
            parametro[cont].Value = CICLO;

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_AFASTAMENTO]");

            return ui;
        }

        async Task<DataTable> IRepositoryColaborador.RGetFindMeta(SearchcColaborador dto, pkxd pkx)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[06];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = pkxd.type;

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

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_META]");

            return ui;
        }

        async Task<DataTable> IRepositoryColaborador.RGetFindMetaResult(int ANOCICLO)
        {
            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[05];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

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

            ClsData pk = new ClsData();

            var ui = await pk.ExecReader(parametro, "[SMetas].[C_RESULTADO]");

            return ui;
        }
    }
}
