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
    public class RepositoryCliente : IRepositoryCliente

    {
       
        async Task<int> IRepositoryCliente.RSaveCliente(Cliente cliente)
        {

            //var tu = Metas.Profile.Profile.A1;
            var tu = Metas.Profile.pkxd.user;


            int cont = 0;

            SqlParameter[] parametro = new SqlParameter[08];

            parametro[cont] = new SqlParameter("@PR_TIPO", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.type;  //  PR_TIPO;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDUSUARIO", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.user;  // PR_IDUSUARIO;

            cont++;
            parametro[cont] = new SqlParameter("@PR_IDFUNCIONALIDADE", SqlDbType.Int);
            parametro[cont].IsNullable = false;
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = Metas.Profile.pkxd.function; //PR_IDFUNCIONALIDADE;

            cont++;
            parametro[cont] = new SqlParameter("@PR_RETURN", SqlDbType.Int);
            parametro[cont].Direction = ParameterDirection.Output;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@Id", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = 0;

            cont++;
            parametro[cont] = new SqlParameter("@Nome", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = cliente.Nome;

            cont++;
            parametro[cont] = new SqlParameter("@SobreNome", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = cliente.SobreNome;

            cont++;
            parametro[cont] = new SqlParameter("@Email", SqlDbType.VarChar);
            parametro[cont].Direction = ParameterDirection.Input;
            parametro[cont].Value = cliente.Email;

             ClsData pk = new ClsData();
            var ui = await pk.ExecRunPar(parametro, "[SMetas].[I_CLIENTE]");

            return ui;
            //return await _ServiceCliente.SaveCliente(cliente);
            //throw new NotImplementedException();
           // return 1;  
        }

        public int AAARSaveCliente(Cliente cliente)
        {
            SqlParameter[] parametro = new SqlParameter[08];
            ClsData pk = new ClsData();
            var rt = pk.ExecRunPar(parametro, "[SMetas].[I_CLIENTE]");
            //throw new NotImplementedException();
            return 1;
        }
    }
}
