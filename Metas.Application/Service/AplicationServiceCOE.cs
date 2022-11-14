using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.DomainCore.Interface;
using Metas.DomainCore.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplicationServiceCOE : IAplicationServiceCOE
    {

        private readonly IServiceCOE _ServiceCOE;
        public AplicationServiceCOE(IServiceCOE serviceCOE)
        {
            this._ServiceCOE = serviceCOE;
        }

        public async Task<FormFormDTO> onGetListForm(int IDCELULATRABALHO)
        {
            var result = await  _ServiceCOE.GetListForm(IDCELULATRABALHO);

            FormFormDTO listform = new FormFormDTO();
            List<FormDTO> lgestor = new List<FormDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                FormDTO ucicloDTO = new FormDTO();

                ucicloDTO.IDFORMULARIOMETA = (int)result.Rows[i]["IDFORMULARIOMETA"];
                ucicloDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();

                lgestor.Add(ucicloDTO);

            }
            listform.ListForm = lgestor;

            return listform;

        }
    }
}
