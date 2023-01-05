using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryCOE
    {
        Task<DataTable> RGetListForm(int IDCELULATRABALHO);
        Task<DataTable> RListOperatingUnit();
        Task<DataTable> RGetListGestor(int IDUNIDADEOPERACIONAL);
        Task<DataTable> RGetListSchedule();
        Task<int> RSaveIndicador(Indicador indicador);
        Task<DataTable> RGetListIndicatorAdd(int IDCELULATRABALHO);
        Task<DataTable> RGetIndicatorLibrary(int PAGINA, int NPAGINA, int ATIVO, string BUSCA);
        Task<int> RSaveFormLibrary(IndicadorSAP indicador);
        Task<int> RSaveSchedule(CronogramaAplicado cronograma);
    }
}
