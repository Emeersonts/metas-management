using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplicationServiceCliente : IAplicationServiceCliente
    {


        private readonly IServiceCliente _ServiceCliente;
        public AplicationServiceCliente(IServiceCliente serviceCliente)
        {
            this._ServiceCliente = serviceCliente;
        }


        public async Task<int> OnAddCliente(ClienteDTO dto)
        {

            // 1 validar consistencia das informações digitadas
            // 2 validar se o cliete já existe 
            //3 tranfoma o DTO em classe domain m, se for o caso


            if (dto.email == "emerson")
            {
                return 1;
                //throw new ValidationException("campaignValidatorResult");
            }


            var cliente = new Cliente(dto.Nome, dto.Sobrenome, dto.email);

            //var user = new User(dto.Login, dto.Name, Password.FromEncrypted(Password.FromString(dto.Password)));

            var gj = await _ServiceCliente.SaveCliente(cliente);
            //return await _ServiceCliente.SaveCliente(cliente);
            return gj;
            //return 1;
            //aplicationServiceCliente.OnAddCliente(dto);


            //throw new NotImplementedException();

        }

            //public void Add(ClienteDTO clientedto)
            //{
            //    throw new NotImplementedException();
            //}

            //public IEnumerable<ClienteDTO> Getall()
            //{
            //    throw new NotImplementedException();
            //}

            //public async System.Threading.Tasks.Task<ClienteDTO> Add(ClienteDTO)
            ////public void Add(ClienteDTO clientedto)
            ////public async Task<ApprovalPageableResultDTO> OnFindApprovalBy(ApprovalListParameterDTO dto)
            //{

            //    var resuilt = new ClienteDTO();
            //    resuilt.Id = 1;
            //    resuilt.Nome = "aaa";
            //    resuilt.Sobrenome = "ggg";

            //    //return resuilt;
            //    //throw new NotImplementedException();
            //}

            //public IEnumerable<ClienteDTO> Getall()
            //{
            //    throw new NotImplementedException();
            //}

            //public ClienteDTO GetByid(int Id)
            //{
            //    throw new NotImplementedException();
            //}

            //public void Remove(ClienteDTO clientedto)
            //{
            //    throw new NotImplementedException();
            //}

            //public void Update(ClienteDTO clientedto)
            //{
            //    throw new NotImplementedException();
            //}
        public Task OnApprove(ClienteDTO[] dto)
        {
            throw new NotImplementedException();
        }

        //public Task OnAddcline(ClienteDTO dto)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
