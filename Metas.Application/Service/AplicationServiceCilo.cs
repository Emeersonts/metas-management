using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplicationServiceCilo : IAplicationServiceCiclo
    {

        private readonly IServiceCilo _ServiceCiclo;
        public AplicationServiceCilo(IServiceCilo serviceCiclo)
        {
            this._ServiceCiclo = serviceCiclo;
        }

        public async Task<ListCicloDTO> OnGetListCiclo()
        {
            var result = await _ServiceCiclo.GetFindGetListCiclo();

            ListCicloDTO listcicli = new ListCicloDTO();
            List<Ciclo> lciclo = new List<Ciclo>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                Ciclo ucicloDTO = new Ciclo();

                ucicloDTO.ANOCICLO = (int)result.Rows[i]["ANOCICLO"];

                lciclo.Add(ucicloDTO);

            }
            listcicli.ListCiclo = lciclo;

            return listcicli;

        }

        public async Task<ListStatusAtribuidoDTO> OnGetListProgressStatus(CicloUsuarioDTO dto)
        {
            var result = await _ServiceCiclo.GetFindGetListProgressStatus(new SearchcColaborador(dto.ANOCICLO, dto.MES));

            ListStatusAtribuidoDTO liststatusatribuido = new ListStatusAtribuidoDTO();
            List<StatusAtribuido> lstatusAtribuido = new List<StatusAtribuido>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                StatusAtribuido uStatusAtribuidoDTO = new StatusAtribuido();

                uStatusAtribuidoDTO.DATAEFETIVA = (DateTime)result.Rows[i]["DATAEFETIVA"];
                uStatusAtribuidoDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                uStatusAtribuidoDTO.IDSTATUSCICLO = (int)result.Rows[i]["IDSTATUSCICLO"];
                
                lstatusAtribuido.Add(uStatusAtribuidoDTO);
            }

            liststatusatribuido.ListStatusAtribuido = lstatusAtribuido;

            return liststatusatribuido;
        }
    }
}
