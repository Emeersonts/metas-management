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
    }
}
