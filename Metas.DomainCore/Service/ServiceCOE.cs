using Metas.DomainCore.Interface;
using Metas.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
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

        public async Task<DataTable> GetListGestor(int idunidadeoperacional)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListGestor(idunidadeoperacional);

            return result;
        }

        public async Task<DataTable> GetListSchedule()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListSchedule();

            return result;
        }

        public async Task<DataTable> ListOperatingUnit()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RListOperatingUnit();

            return result;
        }
    }
}
