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
    public class ServiceRepresentante : IServiceRepresentante
    {
        private readonly IRepositoryRepresentante _repository;
        public ServiceRepresentante(IRepositoryRepresentante repository)
        {
            this._repository = repository;
        }

        public async Task<DataTable> GetFindColaborador(SearchcRepresentanteDTO parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindColaborador(parameters);

            return result;

        }

        public async Task<DataTable> GetFindIndicatorSAP(SearchcRepresentanteDTO parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindIndicatorSAP(parameters);

            return result;
        }

        public async Task<DataTable> GetGoalsReport(int ciclo)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetGoalsReport(ciclo);

            return result;
        }

        public async Task<DataTable> GetListIndicatorAdd(SearchcIndicadorDTO parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListIndicatorAdd(parameters);

            return result;
        }

        public async Task<DataTable> GetListsolicitation(SearchcSolicitgacaoDTO parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListsolicitation(parameters);

            return result;
        }

        public async Task<int> RemoveIndicador(int idindicador)
        {
            var result = await _repository.RRemoveIndicador(idindicador);
            return result;
        }

        public async Task<int> SaveIndicador(Indicador parameters)
        {
            var result = await _repository.RSaveIndicador(parameters);
            return result;
        }

        public async Task<DataTable> Timeline()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RTimeline();

            return result;
        }
    }
}
