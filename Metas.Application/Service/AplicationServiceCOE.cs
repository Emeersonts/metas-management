using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
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

        public async Task<ForDropGestorDTO> onGetListGestor(int IDUNIDADEOPERACIONAL)
        {
            var result = await _ServiceCOE.GetListGestor(IDUNIDADEOPERACIONAL);

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

        public async Task<ForUnidOperacionalDTO> onListOperatingUnit()
        {
            var result = await _ServiceCOE.ListOperatingUnit();

            ForUnidOperacionalDTO listUOperacional = new ForUnidOperacionalDTO();

            List<UnidOperacionaDTO> luoperacional = new List<UnidOperacionaDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                UnidOperacionaDTO uUnitOperacional = new UnidOperacionaDTO();
                uUnitOperacional.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                uUnitOperacional.IDUNIDADEOPERACIONAL = (int)result.Rows[i]["IDUNIDADEOPERACIONAL"];

                luoperacional.Add(uUnitOperacional);

            }

            listUOperacional.LisUnidOperacional = luoperacional;

            return listUOperacional;
        }

        public async Task<ForCronogramaAplicadoDTO> onListSchedule()
        {
            var result = await _ServiceCOE.GetListSchedule();

            ForCronogramaAplicadoDTO listCronogAplicado = new ForCronogramaAplicadoDTO();

            List<CronogramaAplicadoDTO> Lcraplicado = new List<CronogramaAplicadoDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                CronogramaAplicadoDTO Ucraplicado = new CronogramaAplicadoDTO();
                Ucraplicado.IDCRONOGRAMA = (int)result.Rows[i]["IDCRONOGRAMA"];
                Ucraplicado.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                Ucraplicado.ATIVO = (int)result.Rows[i]["ATIVO"];
                if (result.Rows[i]["DATAPROGRAMADA"] != DBNull.Value) { Ucraplicado.DATAPROGRAMADA = (DateTime)result.Rows[i]["DATAPROGRAMADA"]; }

                Lcraplicado.Add(Ucraplicado);

            }

            listCronogAplicado.ListCrAplicado = Lcraplicado;

            return listCronogAplicado;

        }

        public async Task<int> onSaveSchedule(ForCronogramaAplicadoDTO dto)
        {
            // rceber o focmulario e enviar um a um para gravar deletar (se de erro em algum , para a operação

            var thh = dto;
            thh.ListCrAplicado.GetEnumerator();

            var gg = new ForCronogramaAplicadoDTO();
            
            
            
            ForCronogramaAplicadoDTO hh = new ForCronogramaAplicadoDTO();
            hh = dto;


            CronogramaAplicadoDTO Registro = new CronogramaAplicadoDTO();
            



               //-- var tipoedicaoformulario = new ForCronogramaAplicadoDTO(dto.ANOCICLO, dto.IDTIPOEDICAOFORMULARIO, dto.IDREPRESENTANTE,
               // --dto.IDSUPLENTE, dto.IDCELULATRABALHO, dto.IDSTATUSCICLO);

            //--var resultIndicador = await _ServiceGestor.PutSaveFormEditType(tipoedicaoformulario);

            
            return 0;

        }
    }
}
