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
    }
}
