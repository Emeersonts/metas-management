using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.DTO;
using Metas.Infrastructure.Interface;
using Metas.Profile;
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

        public async Task<DataTable> GetFindAfastamento(int CICLO)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindAfastamento(CICLO);

            return result;

        }

        public async Task<DataTable> GetFindMeta(SearchcColaborador parameters, pkxd pkx)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindMeta(parameters, pkx);

            return result;
        }

        public async Task<DataTable> GetFindMetaResult(int anociclo, pkxd pkx)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindMetaResult(anociclo);

            return result;

        }

    }
}
