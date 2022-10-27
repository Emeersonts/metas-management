﻿using Metas.Domain;
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
    public class ServiceGestor : IServiceGestor
    {
        private readonly IRepositoryGestor _repository;
        public ServiceGestor(IRepositoryGestor repository)
        {
            this._repository = repository;
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
        public async Task<int> PutSaveFormEditType(TipoEdicaoFormulario parametrs)
        {
            var result = await _repository.RSaveFormEditType(parametrs);
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
