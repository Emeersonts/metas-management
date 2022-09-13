﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure
{
    public class ClsData
    {
        public Task<int> ExecRunPar(SqlParameter[] parametro, string nomeProc)
        {
            SqlConnection.ClearAllPools();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "STFSAOC045548-L\\SQLEXPRESS";
            builder.UserID = "Lmetas";
            builder.Password = "Pzero#12";
            builder.InitialCatalog = "bMetas";
            SqlConnection conn = new SqlConnection(builder.ConnectionString);

            SqlCommand cmd = new SqlCommand(nomeProc, conn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametro);
                conn.Open();

                cmd.ExecuteScalar();

                int tt = Convert.ToInt16(cmd.Parameters["@PR_RETURN"].Value.ToString());
                return Task.FromResult(tt);

            }

            catch (SqlException EX)

            {
                conn.Close();
                throw EX;
            }

            finally
            {
                conn.Close();
            }
        }
        public Task<DataTable> ExecReader(SqlParameter[] parametro, string nomeProc)
        {
            SqlConnection.ClearAllPools();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "STFSAOC045548-L\\SQLEXPRESS";
            builder.UserID = "Lmetas";
            builder.Password = "Pzero#12";
            builder.InitialCatalog = "bMetas";

            SqlConnection conn = new SqlConnection(builder.ConnectionString);

            try
            {
                SqlCommand cmd = new SqlCommand(nomeProc, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(parametro);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dados = new DataTable();
                dados.Load(reader);

                return Task.FromResult(dados);

            }

            catch (SqlException ex)
            {
                conn.Close();
                throw ex;
            }

            finally
            {
                conn.Close();
            }
        }

    }
}
