using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
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

        public async Task<ForTipóEdicaoDTO> OnGetFormTtype(int ciclo)
        {
            ForTipóEdicaoDTO LForTipoEdicao = new ForTipóEdicaoDTO();

            var resultAfast = await _ServiceGestor.GetFormTtype(ciclo);
            List<TipoEdicaoFormDTO> Itipoedicao = new List<TipoEdicaoFormDTO>();

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                TipoEdicaoFormDTO uMeta = new TipoEdicaoFormDTO();
                uMeta.DESCRICAO = resultAfast.Rows[J]["DESCRICAO"].ToString();
                uMeta.IDTIPOEDICAOFORMULARIO = (int)resultAfast.Rows[J]["IDTIPOEDICAOFORMULARIO"];
                Itipoedicao.Add(uMeta);
            }

            LForTipoEdicao.LisFormEdicao = Itipoedicao;
            return LForTipoEdicao;
        }

        public async Task<int> onSaveFormEditType(TipoEdicaoformularioDTO dto)
        {
            var tipoedicaoformulario = new TipoEdicaoFormulario(dto.ANOCICLO, dto.IDTIPOEDICAOFORMULARIO, dto.IDREPRESENTANTE,
                dto.IDSUPLENTE, dto.IDCELULATRABALHO, dto.MESTRANFERENCIA);

            var resultIndicador = await _ServiceGestor.PutSaveFormEditType(tipoedicaoformulario);

            return resultIndicador;
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
                uMeta.IDCELULATRABALHO = (int)resultAfast.Rows[J]["IDCELULATRABALHO"];
                uMeta.IDFORMULARIOMETA = (int)resultAfast.Rows[J]["IDFORMULARIOMETA"];
                Imeta.Add(uMeta);
            }

            LForMetarelatorio.Listequipe = Imeta;
            return LForMetarelatorio;
        }
    }
}
