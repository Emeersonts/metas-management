using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Metas.DomainCore.Service
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly IRepositoryCliente _repository;

        public ServiceCliente(IRepositoryCliente repository)
        {
            this._repository = repository;
        }

        public async Task<int> SaveCliente(Cliente cliente)
        {
            return await _repository.RSaveCliente(cliente);

            //return 1;

        }

        //public async Task SaveCliente(Cliente cliente)
        //{

        //    try
        //    {
        //        await _repository.RSaveCliente(cliente);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }





        // use o repository  e gera na base de dados que devolvera ok


        //throw new NotImplementedException();

    }
}
