using Metas.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceCliente
    {
        public Task OnApprove(ClienteDTO[] dto);
        Task<int> OnAddCliente(ClienteDTO dto);


        //Task<ApprovalPageableResultDTO> OnFindApprovalBy(ApprovalListParameterDTO dto);
        //Task OnDecline(DeclineCampaingDTO dto);
        //Task OnSubmitForApproval(CampaignSubmitApprovalDTO dto);
        //Task<StatusKeyDTO[]> OnGetAllStatus();
        //public async Task<ClienteDTO> OnFindApprovalBy(ClienteDTO dto);
        //public Add(ClienteDTO clientedto);

        //void Update(ClienteDTO clientedto);
        //void Remove(ClienteDTO clientedto);
        //IEnumerable<ClienteDTO>  Getall();
        //ClienteDTO GetByid(int Id);

    }
}
