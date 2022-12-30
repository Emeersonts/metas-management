using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrystalReportWebAPI.Data
{
    class Connection
    {

        //builder.DataSource = "dev-metas-system-management-database.c3vcojkjp9yx.us-east-1.rds.amazonaws.com";
        //    builder.UserID = "admin";
        //    builder.Password = "GHWFV8HB0oViP1FbEPhl";
        //    builder.InitialCatalog = "bMetas"

        public static string conexao = @"Data Source=dev-metas-system-management-database.c3vcojkjp9yx.us-east-1.rds.amazonaws.com;Initial Catalog=bMetas;Persist Security Info=True;User ID=admin;Password=GHWFV8HB0oViP1FbEPhl";

        //public static string conexao = @"Data Source=STFSAOC045548-L\\SQLEXPRESS;Initial Catalog=bMetas;Persist Security Info=True;User ID=LMetas;Password=Pzero#12";


    }
}
