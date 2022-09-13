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
    public class ServiceRepresentante : IServiceRepresentante
    {
        private readonly IRepositoryRepresentante _repository;
        public ServiceRepresentante(IRepositoryRepresentante repository)
        {
            this._repository = repository;
        }

        public async Task<DataTable> GetFindIndicatorSAP(SearchcRepresentanteDTO parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindIndicatorSAP(parameters);

            return result;
        }
    }
}
