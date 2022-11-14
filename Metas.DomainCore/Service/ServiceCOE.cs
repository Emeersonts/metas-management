using Metas.DomainCore.Interface;
using Metas.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Service
{
    public class ServiceCOE : IServiceCOE
    {
        private readonly IRepositoryCOE _repository;

        public ServiceCOE(IRepositoryCOE repository)
        {
            this._repository = repository;
        }

        public async Task<DataTable> GetListForm(int idcelulatrabalho)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListForm(idcelulatrabalho);

            return result;
        }
    }
}
