﻿using Metas.DomainCore.Interface;
using Metas.Infrastructure.Interface;
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

        public async Task<DataTable> GetGoalsReport(int ciclo)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetGoalsReport(ciclo);

            return result;
        }

    }
}
