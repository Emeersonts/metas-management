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
    public class ServiceRepresentante : IServiceRepresentante
    {
        private readonly IRepositoryRepresentante _repository;
        public ServiceRepresentante(IRepositoryRepresentante repository)
        {
            this._repository = repository;
        }

        public async Task<DataTable> GetAddSIndicator(int ciclo)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetAddSIndicator(ciclo);

            return result;
        }

        public async Task<DataTable> GetFindColaborador(int PAGINA,int qtpagina)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindColaborador(PAGINA,qtpagina);

            return result;

        }

        public async Task<DataTable> GetFindIndicatorSAP(SearchcRepresentanteDTO parameters)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindIndicatorSAP(parameters);

            return result;
        }

        public async Task<DataTable> GetGoalsReport(int ciclo, pkxd pkx)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetGoalsReport(ciclo, pkx);

            return result;
        }

        public async Task<DataTable> GetListIndicatorAdd(SearchcIndicadorDTO parameters, pkxd pkx)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListIndicatorAdd(parameters, pkx);

            return result;
        }

        public async Task<DataTable> GetListProcess()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListProcess();

            return result;
        }

        public async Task<DataTable> GetListsolicitation(SearchcSolicitgacaoDTO parameters, int anopciclo, int pagina, int npagina)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListsolicitation(parameters, anopciclo, pagina, npagina);

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

        public async Task<int> SendForApprovalIndicador(int ANOCILO)
        {
            var result = await _repository.RSendForApprovalIndicador(ANOCILO);
            return result;
        }

        public async Task<int> SendResultForApproval(int anociclo)
        {
            var result = await _repository.RSendResultForApproval(anociclo);
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
