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
    }
}
