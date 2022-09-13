using Metas.DomainCore.Interface;
using Metas.Infrastructure.DTO;
using Metas.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Service
{
    public class ServiceCiclo : IServiceCilo
    {
        private readonly IRepositoryCiclo _repository;
        public ServiceCiclo(IRepositoryCiclo repository)
        {
            this._repository = repository;
        }

        public async Task<DataTable> GetFindGetListCiclo()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindGetListCiclo();

            return result;
        }

        public async Task<DataTable> GetFindGetListProgressStatus(SearchcColaborador parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindGetListProgressStatus(parameters);

            return result;
        }
    }
}
