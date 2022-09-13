using Metas.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryCliente
    {
        Task<int> RSaveCliente(Cliente cliente);
        //Task<int> RSaveCliente(Cliente cliente);
        //public void ARSaveCliente(Cliente cliente);
        //Task RSaveCliente(Cliente cliente);
        public int AAARSaveCliente(Cliente cliente);
        //public void gta(Cliente cliente);
    }
}
