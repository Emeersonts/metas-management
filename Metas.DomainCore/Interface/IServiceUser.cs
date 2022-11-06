using Metas.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceUser
    {
        Task<DataTable> GetTutorialByUser();
        Task<DataTable> GetGetCulture();
        Task<DataTable> GetUserNotification(int ANOCICLO, int IDCELULATRABALHO);
        Task DeactiveTutorial(TutorialUsuario tutotialusuairo);
        Task<DataTable> GetListFrequency();
        Task<DataTable> GetListMeasure();
    }
}
