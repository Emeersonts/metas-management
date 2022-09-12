using Metas.Domain;
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
    public class Servicecolaborador : IServiceColaborador
    {

        private readonly IRepositoryColaborador _repository;
        public Servicecolaborador(IRepositoryColaborador repository)
        {
            this._repository = repository;
        }

        public async Task<DataTable> GetFindAfastamento(SearchcColaborador parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindAfastamento(parameters);

            return result;

        }

        public async Task<DataTable> GetFindMeta(SearchcColaborador parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindMeta(parameters);

            return result;
        }

        public async Task<DataTable> GetFindMetaResult(SearchcColaborador parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindMetaResult(parameters);

            return result;

        }
    }
}
