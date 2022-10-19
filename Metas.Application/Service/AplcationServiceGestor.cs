using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplcationServiceGestor : IAplcationServiceGestor
    {

        private readonly IServiceGestor  _ServiceGestor;
        public AplcationServiceGestor(IServiceGestor serviceGestor)
        {
            this._ServiceGestor = serviceGestor;
        }

        public async Task<ForEquipeDTO> OnVializeTeam(int ciclo)
        {
            ForEquipeDTO LForMetarelatorio = new ForEquipeDTO();

            var resultAfast = await _ServiceGestor.VializeTeam(ciclo);
            List<EquipeDTO> Imeta = new List<EquipeDTO>();

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                EquipeDTO uMeta = new EquipeDTO();
                uMeta.DESCRICAO  = resultAfast.Rows[J]["DESCRICAO"].ToString();
                uMeta.IDCELULATRABALHO = (int)resultAfast.Rows[J]["NOMEUNIDADEMEDIDA"];
                uMeta.IDFORMULARIOMETA = (int)resultAfast.Rows[J]["IDFORMULARIOMETA"];
                Imeta.Add(uMeta);
            }

            LForMetarelatorio.Listequipe = Imeta;
            return LForMetarelatorio;
        }
    }
}
