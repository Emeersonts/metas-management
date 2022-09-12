using Metas.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceCliente
    {
        // recebe ja como classe domain, se fo ro caso
        Task<int> SaveCliente(Cliente cliente);
    }
}
