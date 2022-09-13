using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceRepresentante
    {
        Task<DataTable> GetFindIndicatorSAP(SearchcRepresentanteDTO parameters);
    }
}
