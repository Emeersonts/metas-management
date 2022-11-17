using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceRH
    {
        Task<DataTable> GetListGestor();
        Task<DataTable> GetListCelula(int idrepresentante);
        Task<DataTable> GetMetaSimulate(int anocilco, int idcelulatrabalho, int mes);
        Task<DataTable> GetVerifyRepresentantative(int anocilco, int idcelulatrabalho);
        Task<DataTable> GetMetaMmanagerStatus(int anociclo, int pagina, int qtpagina, string busca);
        Task<DataTable> GetDropCollaborator();
        Task<DataTable> GetDropEqipCollaborator(int IDCELULATRABALHO);
    }
}
