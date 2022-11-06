using Metas.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryUser
    {
        Task<DataTable> RGetTutorialByUser();
        Task<DataTable> RGetCulture();
        Task<DataTable> RGetUserNotification(int anociclo, int idcelulatrabalho);
        Task<int> RDeactiveTutorial(TutorialUsuario tutorialusuario);
        Task<DataTable> RGetListFrequency();
        Task<DataTable> RGetListMeasure();
    }
}
