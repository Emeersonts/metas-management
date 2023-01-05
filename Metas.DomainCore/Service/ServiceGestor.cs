﻿using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.DTO;
using Metas.Infrastructure.Interface;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Service
{
    public class ServiceGestor : IServiceGestor
    {
        private readonly IRepositoryGestor _repository;
        public ServiceGestor(IRepositoryGestor repository)
        {
            this._repository = repository;
        }

        public async Task<int> AprovarIndicador(int anociclo, int idcelulatrabalho)
        {
            var result = await _repository.RAprovarIndicador(anociclo, idcelulatrabalho);

            return result;
        }

        public async Task<int> AprovarResults(int anociclo, int idcelulatrabalho)
        {
            var result = await _repository.RAprovarResults(anociclo, idcelulatrabalho);

            return result;
        }

        public async Task<int> AprovarResultsJul(int anociclo, int idcelulatrabalho)
        {
            var result = await _repository.RAprovarResultsJul(anociclo, idcelulatrabalho);

            return result;

        }

        public async Task<DataTable> GetFindColaborador(int PAGINA,int QTPAGINA, int IDCELULATRABALHO, int ANOCICLO)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindColaborador(PAGINA, QTPAGINA, IDCELULATRABALHO, ANOCICLO);

            return result;
        }

        public async Task<DataTable> GetFindMeta(SearchcColaborador parameters, pkxd pkx)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindMeta(parameters, pkx);

            return result;
        }

        public async Task<DataTable> GetFindMetaResult(int ANOCICLO, int IDCELULATRABALHO, pkxd pkx)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFindMetaResult(ANOCICLO, IDCELULATRABALHO);

            return result;
        }

        public async Task<DataTable> GetFormTtype(int ciclo)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetFormTtype(ciclo);

            return result;
        }

        public async Task<DataTable> GetGoalsReport(int ciclo)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetGoalsReport(ciclo);

            return result;
        }

        public async Task<DataTable> GetListsolicitation(SearchcSolicitgacaoDTO parameters, int ANOCICLO, int PAGINA, int NPAGINA, int IDCELULATRABALHO)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListsolicitation(parameters, ANOCICLO, PAGINA, NPAGINA, IDCELULATRABALHO);

            return result;

        }

        public async Task<DataTable> GetReviewResults(int ANOCICLO, int IDCELULATRABALHO)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetReviewResults(ANOCICLO, IDCELULATRABALHO);

            return result;
        }

        public async Task<int> PutSaveFormEditType(TipoEdicaoFormulario parametrs)
        {
            var result = await _repository.RSaveFormEditType(parametrs);
            return result;
        }

        public async Task<int> RequestAdjustment(int anociclo, int idcelulatrabalho, string menssagem)
        {
            var result = await _repository.RRequestAdjustmentt(anociclo, idcelulatrabalho, menssagem);

            return result;
        }

        public async Task<int> RequestAdjustmentResult(int anociclo, int idcelulatrabalho, string menssagem)
        {
            var result = await _repository.RRequestAdjustmentResult(anociclo, idcelulatrabalho, menssagem);

            return result;
        }

        public async Task<DataTable> VializeTeam(int ciclo)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RVializeTeam(ciclo);

            return result;
        }
    }
}
