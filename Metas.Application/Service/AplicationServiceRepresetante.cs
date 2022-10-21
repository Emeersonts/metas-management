﻿using Metas.Application.DTO;
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

        public async Task<ForSIndicadorDTO> OnGetAddSIndicator(int CICLO)
        {

            ForSIndicadorDTO lForIndicador = new ForSIndicadorDTO();

            var resultIndicador = await _ServiceRepresentante.GetAddSIndicator(CICLO);
            List<IndicadorSDTO> lIndicador = new List<IndicadorSDTO>();

            for (int J = 0; J < resultIndicador.Rows.Count; J++)
            {
                IndicadorSDTO uLindicador = new IndicadorSDTO();

                uLindicador.JAN = (decimal)resultIndicador.Rows[J]["JAN"];
                uLindicador.FEV = (decimal)resultIndicador.Rows[J]["FEV"];
                uLindicador.MAR = (decimal)resultIndicador.Rows[J]["MAR"];
                uLindicador.ABR = (decimal)resultIndicador.Rows[J]["ABR"];
                uLindicador.MAI = (decimal)resultIndicador.Rows[J]["ABR"];
                uLindicador.JUN = (decimal)resultIndicador.Rows[J]["JUN"];
                uLindicador.JUL = (decimal)resultIndicador.Rows[J]["JUL"];
                uLindicador.AGO = (decimal)resultIndicador.Rows[J]["AGO"];
                uLindicador.SET = (decimal)resultIndicador.Rows[J]["SET"];
                uLindicador.OUT = (decimal)resultIndicador.Rows[J]["OUT"];
                uLindicador.NOV = (decimal)resultIndicador.Rows[J]["NOV"];
                uLindicador.DEZ = (decimal)resultIndicador.Rows[J]["DEZ"];
                uLindicador.IDMETA = (int)resultIndicador.Rows[J]["IDMETA"];
                uLindicador.INDICADOR = resultIndicador.Rows[J]["INDICADOR"].ToString();
                uLindicador.TITULO = resultIndicador.Rows[J]["TITULO"].ToString();
                uLindicador.PESO = (int)resultIndicador.Rows[J]["PESO"];

                lIndicador.Add(uLindicador);
            }

            lForIndicador.ListSIndicador = lIndicador;

            return lForIndicador;
        }

        public async Task<FormColaboradorDTO> OnGetFindColaborador(ColaboradorDTO dto)
        {
            FormColaboradorDTO lForIndicadorSAPDTO = new FormColaboradorDTO();

            var resultAfast = await _ServiceRepresentante.GetFindColaborador(new SearchcRepresentanteDTO(dto.PAGINA));
            List<RColaboradorDTO> lIndicadorSapDTO = new List<RColaboradorDTO>();

            int pgtotal = 0;

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                RColaboradorDTO uLindicadorSAPDTO = new RColaboradorDTO();
                uLindicadorSAPDTO.EMAIL = resultAfast.Rows[J]["EMAIL"].ToString();
                uLindicadorSAPDTO.NOMECOMPLETO = resultAfast.Rows[J]["NOMECOMPLETO"].ToString();
                uLindicadorSAPDTO.NPESSOAL = (int)resultAfast.Rows[J]["NPESSOAL"];
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

        public async Task<ForMetaRelatorioDTO> OnGetGoalsReport(int CICLO)
        {
            ForMetaRelatorioDTO lForIndicador = new ForMetaRelatorioDTO();

            var resultIndicador = await _ServiceRepresentante.GetGoalsReport(CICLO);
            List<MetasDTO> lIndicador = new List<MetasDTO>();

            for (int J = 0; J < resultIndicador.Rows.Count; J++)
            {
                MetasDTO uLindicador = new MetasDTO();
                
                uLindicador.NOMEINDICADOR = resultIndicador.Rows[J]["NOMEINDICADOR"].ToString();
                uLindicador.NOMEUNIDADEMEDIDA = resultIndicador.Rows[J]["NOMEUNIDADEMEDIDA"].ToString();
                uLindicador.DESCRICAO = resultIndicador.Rows[J]["DESCRICAO"].ToString();
                uLindicador.PESO = (decimal)resultIndicador.Rows[J]["PESO"];
                uLindicador.MINIMO = (decimal)resultIndicador.Rows[J]["MINIMO"];
                uLindicador.PLANEJADO = (decimal)resultIndicador.Rows[J]["PLANEJADO"];
                uLindicador.DESAFIO = (decimal)resultIndicador.Rows[J]["DESAFIO"];
                uLindicador.RESULTADOAPURADO = (decimal)resultIndicador.Rows[J]["RESULTADOAPURADO"];
                uLindicador.MESINICIO = (int)resultIndicador.Rows[J]["MES"];
                
                lIndicador.Add(uLindicador);
            }

            lForIndicador.ListMeta = lIndicador;

            return lForIndicador;
        }

        public async Task<FormIndicadorDTO> OnGetListIndicatorAdd(EIndicadorAddDTO dto)
        {
            FormIndicadorDTO lForIndicador = new FormIndicadorDTO();

            var RsultIndicador = await _ServiceRepresentante.GetListIndicatorAdd(new SearchcIndicadorDTO(dto.INDICADORES));
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
                uLindicador.MINIMO = 0;
                uLindicador.PESO = 0;
                uLindicador.PLANEJADO = 0;
                uLindicador.DESAFIO = 0;

                lIndicador.Add(uLindicador);
            }

            lForIndicador.ListIndicador = lIndicador;

            return lForIndicador;

        }

        public async Task<ForSolicitacaoDTO> OnGetListsolicitation(ESolicitacaoDTO dto)
        {
            ForSolicitacaoDTO lForsolicitacao = new ForSolicitacaoDTO();

            var resultSolicitacao = await _ServiceRepresentante.GetListsolicitation(new SearchcSolicitgacaoDTO(dto.BUSCA,dto.ORIGEM,dto.RESPONSACAL,dto.STATUS));
            List<SolicitacaoDTO> lsoliocitacao = new List<SolicitacaoDTO>();

            for (int J = 0; J < resultSolicitacao.Rows.Count; J++)
            {
                SolicitacaoDTO uSolicitacao = new SolicitacaoDTO();

                uSolicitacao.DESCRICAO = resultSolicitacao.Rows[J]["DESCRICAO"].ToString();
                if (resultSolicitacao.Rows[J]["CONCLUSAO"] != DBNull.Value) { uSolicitacao.CONCLUSAO = (DateTime)resultSolicitacao.Rows[J]["CONCLUSAO"]; }
                uSolicitacao.ABERTURA = (DateTime)resultSolicitacao.Rows[J]["ABERTURA"];
                uSolicitacao.ORIGEM = resultSolicitacao.Rows[J]["ORIGEM"].ToString();
                uSolicitacao.RESPONSAVEL = resultSolicitacao.Rows[J]["RESPONSAVEL"].ToString();
                uSolicitacao.STATUS = resultSolicitacao.Rows[J]["STATUS"].ToString();
                uSolicitacao.TITULO = resultSolicitacao.Rows[J]["TITULO"].ToString();
                lsoliocitacao.Add(uSolicitacao);
            }

            lForsolicitacao.ListSolicitacao = lsoliocitacao;

            return lForsolicitacao;
        }

        public async Task<int> OnRemoveIndicador(int idindicador)
        {
            var resultIndicador = await _ServiceRepresentante.RemoveIndicador(idindicador);

            return resultIndicador;
        }

        public async Task<int> OnSaveForm(GIndicadorDTTO dto)
        {
            var Indicador = new Metas.Domain.Indicador(dto.IDINDICADOR, dto.NOME, dto.DESCRICAOINDICADOR, dto.IDUNIDADEMEDIDA,
                dto.IDFREQUENCIA, dto.PESO, dto.MINIMO, dto.PLANEJADO, dto.DESAFIO, dto.ANOCICLO
            );

            var resultIndicador = await _ServiceRepresentante.SaveIndicador(Indicador);

            return resultIndicador;

        }

        public async Task<int> OnSendForApprovalIndicador(int ANOCICLO)
        {
            var resultIndicador = await _ServiceRepresentante.SendForApprovalIndicador(ANOCICLO);
            
            if (resultIndicador == 0)
            {
                EmailEnvia env = new EmailEnvia();
                env.EnviaEmail("a", "a", "a", "a", "a");
                // CHAMADA DO EMAIL
            }

            return resultIndicador;

        }

        async Task<ForCronogramaDTO> IAplicationServiceRepresetante.OnTimeline()
        {
            ForCronogramaDTO lCronogramaDTO = new ForCronogramaDTO();

            var resultAfast = await _ServiceRepresentante.Timeline();
            List<CronogramaDTO> ListCronogramaDTO = new List<CronogramaDTO>();

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                CronogramaDTO uCronogramaDTO = new CronogramaDTO();
                uCronogramaDTO.DATAPROGRAMADA = (DateTime)resultAfast.Rows[J]["DATAPROGRAMADA"];
                uCronogramaDTO.DESCRICAO = resultAfast.Rows[J]["DESCRICAO"].ToString();
                uCronogramaDTO.TITULO = resultAfast.Rows[J]["TITULO"].ToString();

                ListCronogramaDTO.Add(uCronogramaDTO);

            }
            
            lCronogramaDTO.Listform = ListCronogramaDTO;

            return lCronogramaDTO;
        }
    }
}
