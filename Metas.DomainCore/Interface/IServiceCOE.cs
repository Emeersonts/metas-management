using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceCOE
    {
        Task<DataTable> GetListForm(int idcelulatrabalho);
        Task<DataTable> ListOperatingUnit();
        Task<DataTable> GetListGestor(int idunidadeoperacional);
        Task<DataTable> GetListSchedule();
        Task<int> SaveIndicador(Indicador parameters);
        Task<DataTable> GetListIndicatorAdd(int IDANOCICLO);
        Task<DataTable> GetIndicatorLibrary(int PAGINA,int NPAGINA, int ATIVO, string BUSCA);
        Task<int> SaveFormLibrary(IndicadorSAP parameters);
        Task<int> SaveSchedule(CronogramaAplicado parameters);
    }
}
