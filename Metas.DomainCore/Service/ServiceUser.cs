﻿using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Service
{
    public class ServiceUser : IServiceUser
    {
        private readonly IRepositoryUser _repository;
        public ServiceUser(IRepositoryUser repository)
        {
            this._repository = repository;
        }

        public async Task DeactiveTutorial(TutorialUsuario tutorialusuario)
        {
            try
            {
                await _repository.RDeactiveTutorial(tutorialusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DataTable> GetGetCulture()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetCulture();

            return result;
        }

        public async Task<DataTable> GetListFrequency()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListFrequency();

            return result;
        }

        public async Task<DataTable> GetListMeasure()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetListMeasure();

            return result;
        }

        public async Task<DataTable> GetTutorialByUser()
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetTutorialByUser();

            return result;
        }

        public async Task<DataTable> GetUserNotification(int anociclo, int IDCELULATRABALHO, int IDNOTIFICACAO)
        {
            DataTable ty = new DataTable();

            var result = await _repository.RGetUserNotification(anociclo, IDCELULATRABALHO, IDNOTIFICACAO);

            return result;
        }
    }
}
