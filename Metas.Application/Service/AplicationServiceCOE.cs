using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.DomainCore.Service;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
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

        public async Task<FormIndicadorDTO> OnGetListIndicatorAdd(int idcelulatrabalho)
        {
            FormIndicadorDTO lForIndicador = new FormIndicadorDTO();

            var RsultIndicador = await _ServiceCOE.GetListIndicatorAdd(idcelulatrabalho);
            List<IndicadorAddDTO> lIndicador = new List<IndicadorAddDTO>();

            for (int J = 0; J < RsultIndicador.Rows.Count; J++)
            {
                IndicadorAddDTO uLindicador = new IndicadorAddDTO();

                uLindicador.DESCRICAO = RsultIndicador.Rows[J]["DESCRICAO"].ToString();
                uLindicador.DESCRICAOINDICADOR = RsultIndicador.Rows[J]["DESCRICAOINDICADOR"].ToString();
                uLindicador.IDFREQUENCIA = (int)RsultIndicador.Rows[J]["IDFREQUENCIA"];
                uLindicador.IDINDICADOR = (int)RsultIndicador.Rows[J]["IDINDICADOR"];
                uLindicador.IDUNIDADEMEDIDA = (int)RsultIndicador.Rows[J]["IDUNIDADEMEDIDA"];
                uLindicador.NOMEUNIDADEMEDIDA = RsultIndicador.Rows[J]["NOMEUNIDADEMEDIDA"].ToString();
                uLindicador.NOMEINDICADOR = RsultIndicador.Rows[J]["NOMEINDICADOR"].ToString();
                uLindicador.NOME = RsultIndicador.Rows[J]["IDINDICADOR"].ToString();
                uLindicador.MINIMO = (decimal)RsultIndicador.Rows[J]["MINIMO"];
                uLindicador.PESO = (int)RsultIndicador.Rows[J]["PESO"];
                uLindicador.PLANEJADO = (decimal)RsultIndicador.Rows[J]["PLANEJADO"];
                uLindicador.DESAFIO = (decimal)RsultIndicador.Rows[J]["DESAFIO"];
                uLindicador.APURADO = (decimal)RsultIndicador.Rows[J]["APURADO"];
                uLindicador.ORDEMINICIO = (int)RsultIndicador.Rows[J]["ORDEMINICIO"];
                uLindicador.STATUSMETA = (int)RsultIndicador.Rows[J]["STATUSMETA"];
                uLindicador.STATUSRESULTADO = (int)RsultIndicador.Rows[J]["STATUSRESULTADO"];
                uLindicador.STATUSINDICADOR = (int)RsultIndicador.Rows[J]["STATUSINDICADOR"];
                uLindicador.OPNEG = (int)RsultIndicador.Rows[J]["OPNEG"];
                if (RsultIndicador.Rows[J]["DTAAPURACAO"] != DBNull.Value) { uLindicador.DATAAPURACAO = (DateTime)RsultIndicador.Rows[J]["DTAAPURACAO"]; }
                if (RsultIndicador.Rows[J]["SIMULADOAPURADO"] != DBNull.Value) { uLindicador.SIMULADOAPURADO = (decimal)RsultIndicador.Rows[J]["SIMULADOAPURADO"]; }
                lIndicador.Add(uLindicador);
            }

            lForIndicador.ListIndicador = lIndicador;

            return lForIndicador;

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

        public async Task<int> OnSaveForm(int IDCELULATRABALHO, GIndicadorDTTO dto, int OPERACAO)
        {
            var Indicador = new Metas.Domain.Indicador(dto.IDINDICADOR, dto.NOME, dto.DESCRICAOINDICADOR, dto.IDUNIDADEMEDIDA,
                dto.IDFREQUENCIA, dto.PESO, dto.MINIMO, dto.PLANEJADO, dto.DESAFIO, dto.ANOCICLO, dto.MES, dto.APURADO
            );

            var resultIndicador = await _ServiceCOE.SaveIndicador(IDCELULATRABALHO, Indicador,OPERACAO);

            return resultIndicador;

        }

        public async Task<int> onSaveSchedule(CronogramaAplicadoDTO[] dto)
        {

            var ggg = new CronogramaAplicadoDTO[1];
            int gg = 0;

            foreach (var item in dto)
            {
                gg = item.ATIVO;
            }


            return 0;

        }
    }
}
