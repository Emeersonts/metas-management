using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplicationServiceRepresetante : IAplicationServiceRepresetante
    {
        private readonly IServiceRepresentante _ServiceRepresentante;
        public AplicationServiceRepresetante(IServiceRepresentante serviceCiclo)
        {
            this._ServiceRepresentante = serviceCiclo;
        }

        public async Task<FormColaboradorDTO> OnGetFindColaborador(ColaboradorDTO dto)
        {
            FormColaboradorDTO lForIndicadorSAPDTO = new FormColaboradorDTO();

            var resultAfast = await _ServiceRepresentante.GetFindIndicatorSAP(new SearchcRepresentanteDTO(dto.PAGINA));
            List<RColaboradorDTO> lIndicadorSapDTO = new List<RColaboradorDTO>();

            int pgtotal = 0;

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                RColaboradorDTO uLindicadorSAPDTO = new RColaboradorDTO();
                uLindicadorSAPDTO.EMAIL = resultAfast.Rows[J]["EMAIL"].ToString();
                uLindicadorSAPDTO.NOMECOMPLETO = resultAfast.Rows[J]["NOMECOMPLETO"].ToString();
                //uLindicadorSAPDTO.NPESSOAL = (int)resultAfast.Rows[J]["NPESSOAL"].ToString();
                uLindicadorSAPDTO.TITULO = resultAfast.Rows[J]["TITULO"].ToString();

                pgtotal = (int)resultAfast.Rows[J]["PG"];

                lIndicadorSapDTO.Add(uLindicadorSAPDTO);

            }

            lForIndicadorSAPDTO.PGTOTAL = pgtotal;
            lForIndicadorSAPDTO.ListColaborador = lIndicadorSapDTO;

            return lForIndicadorSAPDTO;
        }

        public async Task<ForIndicadorSAP> OnGetFindIndicatorSAP(IndicadorDTO dto)
        {

            ForIndicadorSAP lForIndicadorSAPDTO = new ForIndicadorSAP();

            var resultAfast = await _ServiceRepresentante.GetFindIndicatorSAP(new SearchcRepresentanteDTO(dto.PAGINA, dto.IDFREQUENCIA, dto.BUSCA));
            List<IndicadorSAPDTO> lIndicadorSapDTO = new List<IndicadorSAPDTO>();

            int pgtotal = 0;

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                IndicadorSAPDTO uLindicadorSAPDTO = new IndicadorSAPDTO();
                uLindicadorSAPDTO.IDINDICADOR= (int)resultAfast.Rows[J]["IDINDICADOR"];
                uLindicadorSAPDTO.FREQUENCIADESCRICAO = resultAfast.Rows[J]["FREQUENCIADESCRICAO"].ToString();
                uLindicadorSAPDTO.DESCRICAO = resultAfast.Rows[J]["DESCRICAO"].ToString();
                uLindicadorSAPDTO.NOME = resultAfast.Rows[J]["NOME"].ToString();
                uLindicadorSAPDTO.PROCESSODESCRICAO = resultAfast.Rows[J]["PROCESSODESCRICAO"].ToString();
                uLindicadorSAPDTO.UNIDAQDEMEDIDADESCRICAO = resultAfast.Rows[J]["UNIDAQDEMEDIDADESCRICAO"].ToString();
                pgtotal = (int)resultAfast.Rows[J]["PG"];
                
                lIndicadorSapDTO.Add(uLindicadorSAPDTO);

            }

            lForIndicadorSAPDTO.PGTOTAL = pgtotal;
            lForIndicadorSAPDTO.ListIndicadorSAP = lIndicadorSapDTO;

            return lForIndicadorSAPDTO;

        }

    }
}
