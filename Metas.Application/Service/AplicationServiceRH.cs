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
    public class AplicationServiceRH : IAplicationServiceRH
    {

        private readonly IServiceRH _ServiceRH;
        public AplicationServiceRH(IServiceRH serviceRH)
        {
            this._ServiceRH = serviceRH;
        }

        public async Task<ForDropGestorDTO> onGetListGestor()
        {
            var result = await _ServiceRH.GetListGestor();

            ForDropGestorDTO listgestor = new ForDropGestorDTO();
            List<DropGestorDTO> lgestor = new List<DropGestorDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                DropGestorDTO ucicloDTO = new DropGestorDTO();

                ucicloDTO.NPESSOAL = (int)result.Rows[i]["NPESSOAL"];
                ucicloDTO.NOME = result.Rows[i]["NOME"].ToString();

                lgestor.Add(ucicloDTO);

            }
            listgestor.ListGestor = lgestor;

            return listgestor;

        }
    }
}
