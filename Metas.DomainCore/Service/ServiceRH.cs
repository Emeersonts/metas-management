using Metas.DomainCore.Interface;
using Metas.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Service
{

    public class ServiceRH : IServiceRH
    {
        private readonly IRepositoryRH _repository;
        public ServiceRH(IRepositoryRH repository)
        {
            this._repository = repository;
        }

        public async Task<DataTable> GetListCelula(int idrepresentante)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListCelula(idrepresentante);

            return result;
        }

        public async Task<DataTable> GetListGestor()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListGestor();

            return result;
        }

        public async Task<DataTable> GetMetaSimulate(int anocilco, int idcelulatrabalho, int mes)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetMetaSimulate(anocilco,idcelulatrabalho,mes);

            return result;
        }
    }
}
