﻿using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
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
                            ulMetasDTO.PESO = (decimal)result.Rows[j]["PESO"];
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

        public async Task<ForTipóEdicaoDTO> OnGetFormTtype(int ciclo)
        {
            ForTipóEdicaoDTO LForTipoEdicao = new ForTipóEdicaoDTO();

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

        public async Task<int> onSaveFormEditType(TipoEdicaoformularioDTO dto)
        {
            var tipoedicaoformulario = new TipoEdicaoFormulario(dto.ANOCICLO, dto.IDTIPOEDICAOFORMULARIO, dto.IDREPRESENTANTE,
                dto.IDSUPLENTE, dto.IDCELULATRABALHO, dto.MESTRANFERENCIA);

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
                Imeta.Add(uMeta);
            }

            LForMetarelatorio.Listequipe = Imeta;
            return LForMetarelatorio;
        }
    }
}
