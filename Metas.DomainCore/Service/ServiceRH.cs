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

        public async Task<DataTable> GetListGestor()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListGestor();

            return result;
        }

    }
}
