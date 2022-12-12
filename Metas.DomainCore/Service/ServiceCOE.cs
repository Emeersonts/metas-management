using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.Interface;
using Metas.Profile;
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

        async public Task<DataTable> GetIndicatorLibrary(int PAGINA, int NPAGINA, int ATIVO, string BUSCA)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetIndicatorLibrary(PAGINA, NPAGINA, ATIVO, BUSCA);

            return result;
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

        public async Task<DataTable> GetListIndicatorAdd(int IDANOCICLO)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListIndicatorAdd(IDANOCICLO);

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

        public async Task<int> SaveFormLibrary(IndicadorSAP parameters)
        {
            var result = await _repository.RSaveFormLibrary(parameters);

            return result;
        }

        public async Task<int> SaveIndicador(Indicador parameters)
        {
            var result = await _repository.RSaveIndicador(parameters);

            return result;
        }
    }
}
