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
        Task<DataTable> RGetVerifyRepresentantative(int anocilco, int idcelulatrabalho);
        Task<DataTable> RGetMetaMmanagerStatus(int ANOCICLO, int PAGINA, int QTPAGINA, string BUSCA);
        Task<DataTable> RGetDropCollaborator();
    }
}
