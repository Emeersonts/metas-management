using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.DomainCore.Service;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
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

        public async Task<int> OnAprovarIndicador(int anociclo, int idcelulatrabalho)
        {
            var resultIndicador = await _ServiceGestor.AprovarIndicador(anociclo, idcelulatrabalho);

            if (resultIndicador == 0)
            {
                EmailEnvia env = new EmailEnvia();
                env.EnviaEmail("a", "a", "a", "a", "a");
                // CHAMADA DO EMAIL
            }

            return resultIndicador;
        }

        public async Task<int> OnAprovarResults(int anociclo, int idcelulatrabalho)
        {
            var resultIndicador = await _ServiceGestor.AprovarResults(anociclo, idcelulatrabalho);

            if (resultIndicador == 15)
            {
                ExcelFileClass excelFileClass = new ExcelFileClass();

                excelFileClass.classAG();

                //EmailEnvia env = new EmailEnvia();
                //env.EnviaEmail("a", "a", "a", "a", "a");
                // CHAMADA DO EMAIL
            }

            return resultIndicador;
        }

        public async Task<FormColaboradorDTO> OnGetFindColaborador(int PAGINA,int QTPAGINA, int IDCELULATRABALHO, int ANOCICLO)
        {

            FormColaboradorDTO lForIndicadorSAPDTO = new FormColaboradorDTO();

            var resultAfast = await _ServiceGestor.GetFindColaborador(PAGINA,QTPAGINA, IDCELULATRABALHO, ANOCICLO);
            List<RColaboradorDTO> lIndicadorSapDTO = new List<RColaboradorDTO>();

            int pgtotal = 0;
            int ncolaborador = 0;
            string descricaostatus = "";

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                RColaboradorDTO uLindicadorSAPDTO = new RColaboradorDTO();
                uLindicadorSAPDTO.EMAIL = resultAfast.Rows[J]["EMAIL"].ToString();
                uLindicadorSAPDTO.NOMECOMPLETO = resultAfast.Rows[J]["NOMECOMPLETO"].ToString();
                uLindicadorSAPDTO.NPESSOAL = (int)resultAfast.Rows[J]["NPESSOAL"];
                uLindicadorSAPDTO.TITULO = resultAfast.Rows[J]["TITULO"].ToString();

                pgtotal = (int)resultAfast.Rows[J]["PG"];
                ncolaborador = (int)resultAfast.Rows[J]["NCOLABORADOR"];
                descricaostatus = resultAfast.Rows[J]["DESCRICAOSTATUS"].ToString();
                lIndicadorSapDTO.Add(uLindicadorSAPDTO);

            }
            lForIndicadorSAPDTO.DESCRICAOSTATUS = descricaostatus;
            lForIndicadorSAPDTO.PGTOTAL = pgtotal;
            lForIndicadorSAPDTO.NCOLABORADOR = ncolaborador;
            lForIndicadorSAPDTO.ListColaborador = lIndicadorSapDTO;

            return lForIndicadorSAPDTO;

        }

        public async Task<FormularioMetasDTO> OnGetFindMeta(CicloCelulaDTO dto, pkxd pkx)
        {
            var result = await _ServiceGestor.GetFindMeta(new SearchcColaborador(dto.ANOCICLO, dto.MES, dto.IDCELULATRABALHO), pkx);

            FormularioMetasDTO lFormularioMetasDTO = new FormularioMetasDTO();

            List<FormularioDTO> LformularioDTO = new List<FormularioDTO>();

            string grupo = "";
            string grupom = "";

            for (int i = 0; i < result.Rows.Count; i++)
            {

                if (grupo != (result.Rows[i]["IDFORMULARIOMETA"].ToString() + result.Rows[i]["IDCELULATRABALHO"].ToString()))
                {
                    FormularioDTO uformulariodto = new FormularioDTO();
                    List<MetasDTO> lMetasDTO = new List<MetasDTO>();

                    uformulariodto.IDFORMULARIOMETA = (int)result.Rows[i]["IDFORMULARIOMETA"];
                    uformulariodto.NOMEFORMULARIO = result.Rows[i]["NOMEFORMULARIO"].ToString();
                    uformulariodto.IDCELULATRABALHO = (int)result.Rows[i]["IDCELULATRABALHO"];
                    uformulariodto.IDSTATUS = (int)result.Rows[i]["IDSTATUS"];
                    uformulariodto.NOMESTATUS = result.Rows[i]["NOMESTATUS"].ToString();

                    grupo = (result.Rows[i]["IDFORMULARIOMETA"].ToString() + result.Rows[i]["IDCELULATRABALHO"].ToString());

                    for (int j = 0; j < result.Rows.Count; j++)
                    {
                        grupom = (result.Rows[j]["IDFORMULARIOMETA"].ToString() + result.Rows[j]["IDCELULATRABALHO"].ToString());
                        if (grupom == grupo)
                        {
                            MetasDTO ulMetasDTO = new MetasDTO();
                            ulMetasDTO.MESINICIO = (int)result.Rows[j]["MESINICIO"];
                            ulMetasDTO.NOMEFORMULARIO = result.Rows[j]["NOMEFORMULARIO"].ToString();
                            ulMetasDTO.NOMEINDICADOR = result.Rows[j]["NOMEINDICADOR"].ToString();
                            ulMetasDTO.IDINDICADOR = (int)result.Rows[j]["IDINDICADOR"];
                            ulMetasDTO.NOMEUNIDADEMEDIDA = result.Rows[j]["NOMEUNIDADEMEDIDA"].ToString();
                            ulMetasDTO.DESCRICAO = result.Rows[j]["DESCRICAO"].ToString();
                            ulMetasDTO.PESO = (int)result.Rows[j]["PESO"];
                            ulMetasDTO.ORDEMINICIO = (int)result.Rows[j]["ORDEMINICIO"];
                            ulMetasDTO.MINIMO = (decimal)result.Rows[j]["MINIMO"];
                            ulMetasDTO.PLANEJADO = (decimal)result.Rows[j]["PLANEJADO"];
                            ulMetasDTO.DESAFIO = (decimal)result.Rows[j]["DESAFIO"];
                            ulMetasDTO.RESULTADO = (int)result.Rows[j]["RESULTADO"];
                            if (result.Rows[j]["RESULTADOAPURADO"] != DBNull.Value) { ulMetasDTO.RESULTADOAPURADO = (decimal)result.Rows[j]["RESULTADOAPURADO"]; }
                            if (result.Rows[j]["SIMULADOAPURADO"] != DBNull.Value) { ulMetasDTO.SIMULADOAPURADO = (decimal)result.Rows[j]["SIMULADOAPURADO"]; }
                            if (result.Rows[j]["DATAAPURACAO"] != DBNull.Value) { ulMetasDTO.DATAAPURACAO = (DateTime)result.Rows[j]["DATAAPURACAO"]; }
                            lMetasDTO.Add(ulMetasDTO);
                        }
                    }

                    uformulariodto.ListMeta = lMetasDTO;
                    LformularioDTO.Add(uformulariodto);
                }
            }

            lFormularioMetasDTO.Listform = LformularioDTO;

            return lFormularioMetasDTO;
        }

        public async Task<ForMetasResultDTO> OnGetFindMetaResult(int anociclo, int idcelulatrabalho, pkxd pkx)
        {
            var result = await _ServiceGestor.GetFindMetaResult(anociclo,idcelulatrabalho, pkx);

            ForMetasResultDTO lFormularioMetasResultDTO = new ForMetasResultDTO();
            List<MetaResultDTO> lMetasResultDTO = new List<MetaResultDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                MetaResultDTO ulMetasResulDTO = new MetaResultDTO();
                ulMetasResulDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                ulMetasResulDTO.RESULTADOCLICLO = result.Rows[i]["RESULTADOCLICLO"].ToString();
                if (result.Rows[i]["APURADO"] != DBNull.Value) { ulMetasResulDTO.APURADO = (decimal)result.Rows[i]["APURADO"]; }
                if (result.Rows[i]["MESINICIO"] != DBNull.Value) { ulMetasResulDTO.APURADO = (int)result.Rows[i]["MESINICIO"]; }
                ulMetasResulDTO.DATAAPURACAO = (DateTime)result.Rows[i]["DATAAPURACAO"];
                ulMetasResulDTO.IDRESULTADOCICLO = (int)result.Rows[i]["IDRESULTADOCICLO"];
                lMetasResultDTO.Add(ulMetasResulDTO);
            }

            lFormularioMetasResultDTO.ListMetaResult = lMetasResultDTO;
            return lFormularioMetasResultDTO;
        }

        public async Task<ForTipoEdicaoDTO> OnGetFormTtype(int ciclo)
        {
            ForTipoEdicaoDTO LForTipoEdicao = new ForTipoEdicaoDTO();

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

        public async Task<ForSolicitacaoDTO> OnGetListsolicitation(ESolicitacaoDTO dto, int anociclo, int pagina, int npagina, int idcelulatrabalho)
        {
            ForSolicitacaoDTO lForsolicitacao = new ForSolicitacaoDTO();

            var resultSolicitacao = await _ServiceGestor.GetListsolicitation(new SearchcSolicitgacaoDTO(dto.BUSCA, dto.ORIGEM, dto.RESPONSAVEL, dto.STATUS), anociclo, pagina, npagina, idcelulatrabalho);
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
                uSolicitacao.OBS = resultSolicitacao.Rows[J]["OBS"].ToString();
                lsoliocitacao.Add(uSolicitacao);
            }

            lForsolicitacao.ListSolicitacao = lsoliocitacao;

            return lForsolicitacao;
        }

        public async Task<FormRevisaoResultadoDTO> OnGetReviewResults(int anociclo, int idcelulatrabalho)
        {
            var result = await _ServiceGestor.GetReviewResults(anociclo, idcelulatrabalho);

            FormRevisaoResultadoDTO lFormularioMetasResultDTO = new FormRevisaoResultadoDTO();
            List<RevisaoResultadoDTO> lMetasResultDTO = new List<RevisaoResultadoDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                RevisaoResultadoDTO uRevisaoResult = new RevisaoResultadoDTO();
                uRevisaoResult.JAN = (decimal)result.Rows[i]["JAN"];
                uRevisaoResult.FEV = (decimal)result.Rows[i]["FEV"];
                uRevisaoResult.MAR = (decimal)result.Rows[i]["MAR"];
                uRevisaoResult.MAI = (decimal)result.Rows[i]["MAI"];
                uRevisaoResult.JUN = (decimal)result.Rows[i]["JUN"];
                uRevisaoResult.AGO = (decimal)result.Rows[i]["AGO"];
                uRevisaoResult.SET = (decimal)result.Rows[i]["SET"];
                uRevisaoResult.OUT = (decimal)result.Rows[i]["OUT"];
                uRevisaoResult.NOV = (decimal)result.Rows[i]["NOV"];
                uRevisaoResult.DEZ = (decimal)result.Rows[i]["DEZ"];
                uRevisaoResult.IDMETA = (int)result.Rows[i]["IDEMETA"];
                uRevisaoResult.NOMEFREQUENCIA = result.Rows[i]["NOMEFREQUENCIA"].ToString() ;
                uRevisaoResult.NOMEINDICADOR = result.Rows[i]["NOMEINDICADOR"].ToString();
                uRevisaoResult.NOMEUNIDADEMEDIDA = result.Rows[i]["NOMEUNIDADEMEDIDA"].ToString();
                uRevisaoResult.PESO = (int)result.Rows[i]["PESO"];

                lMetasResultDTO.Add(uRevisaoResult);
            }

            lFormularioMetasResultDTO.ListRevisaoResultado = lMetasResultDTO;
            return lFormularioMetasResultDTO;
        }

        public async Task<int> OnRequestAdjustment(int anociclo, int idcelulatrabalho, string menssagem)
        {
            var resultIndicador = await _ServiceGestor.RequestAdjustment(anociclo, idcelulatrabalho, menssagem);

            if (resultIndicador == 0)
            {
                EmailEnvia env = new EmailEnvia();
                env.EnviaEmail("a", "a", "a", "a", "a");
                // CHAMADA DO EMAIL
            }

            return resultIndicador;
        }

        public async Task<int> OnRequestAdjustmentResult(int anociclo, int idcelulatrabalho, string menssagem)
        {
            var resultIndicador = await _ServiceGestor.RequestAdjustmentResult(anociclo, idcelulatrabalho, menssagem);

            if (resultIndicador == 0)
            {
                EmailEnvia env = new EmailEnvia();
                env.EnviaEmail("a", "a", "a", "a", "a");
                // CHAMADA DO EMAIL
            }

            return resultIndicador;

        }

        public async Task<int> onSaveFormEditType(TipoEdicaoformularioDTO dto)
        {
            var tipoedicaoformulario = new TipoEdicaoFormulario(dto.ANOCICLO, dto.IDTIPOEDICAOFORMULARIO, dto.IDREPRESENTANTE,
                dto.IDSUPLENTE, dto.IDCELULATRABALHO, dto.IDSTATUSCICLO);

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
                uMeta.UACESSO = (DateTime)resultAfast.Rows[J]["UACESSO"];
                Imeta.Add(uMeta);
            }

            LForMetarelatorio.Listequipe = Imeta;
            return LForMetarelatorio;
        }
    }
}
