using Autofac;
using System;
using System.Collections.Generic;
using System.Text;


namespace Metas.Infrastructure
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            //#region Registra IOC

            //#region IOC Application
            //builder.RegisterType<ApplicationServiceCliente>().As<IIAplicationServiceCliente>();
            
            //builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            //#endregion

            //#region IOC Services
            //builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            //builder.RegisterType<IServiceProduto>().As<IServiceProduto>();
            //#endregion

            //#region IOC Repositorys SQL
            //builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            //builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            //#endregion

            //#region IOC Mapper
            //builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            //builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            //#endregion

            //#endregion

        }
    }
}