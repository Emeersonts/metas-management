using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryRH
    {
        Task<DataTable> RGetListGestor();
        Task<DataTable> RGetListCelula(int idrepresentante);
        Task<DataTable> RGetMetaSimulate(int anocilco, int idcelulatrabalho, int mes);
    }
}
