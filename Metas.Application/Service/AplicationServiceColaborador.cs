using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.DomainCore.Interface;
using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplicationServiceColaborador : IAplicationServiceColaborador
    {
        private readonly IServiceColaborador _ServiceColaborador;
        public AplicationServiceColaborador(IServiceColaborador serviceColaborador)
        {
            this._ServiceColaborador = serviceColaborador;
        }

        public async Task<FormularioResultadoMeta> OnGetFindAfastamento(int CICLO)
        {
            FormularioResultadoMeta lFormularioResultadoMetasDTO = new FormularioResultadoMeta();

            var resultAfast = await _ServiceColaborador.GetFindAfastamento(CICLO);
            List<AfastamentDTO> lAfastamentoDTO = new List<AfastamentDTO>();

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                AfastamentDTO uLAfastamento = new AfastamentDTO();
                uLAfastamento.DATAAFASTAMENTO = (DateTime)resultAfast.Rows[J]["DATAAFASTAMENTO"];
                uLAfastamento.DATARETORNO = (DateTime)resultAfast.Rows[J]["DATARETORNO"];
                uLAfastamento.DESCRICAO = resultAfast.Rows[J]["DESCRICAO"].ToString();

                lAfastamentoDTO.Add(uLAfastamento);
            }

            lFormularioResultadoMetasDTO.ListAfastamento = lAfastamentoDTO;
         
            return lFormularioResultadoMetasDTO;

        }

        public async Task<FormularioMetasDTO> OnGetFindMeta(CicloUsuarioDTO dto)
        {
            var result = await _ServiceColaborador.GetFindMeta(new SearchcColaborador(dto.ANOCICLO, dto.MES));

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

        public async Task<ForMetasResultDTO> OnGetFindMetaResult(CicloUsuarioDTO dto)
        {
            var result = await _ServiceColaborador.GetFindMetaResult(new SearchcColaborador(dto.ANOCICLO, dto.MES));

            ForMetasResultDTO lFormularioMetasResultDTO = new ForMetasResultDTO();
            List<MetaResultDTO> lMetasResultDTO = new List<MetaResultDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                MetaResultDTO ulMetasResulDTO = new MetaResultDTO();
                ulMetasResulDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                ulMetasResulDTO.RESULTADOCLICLO = result.Rows[i]["RESULTADOCLICLO"].ToString();
                ulMetasResulDTO.APURADO = (decimal)result.Rows[i]["APURADO"];
                ulMetasResulDTO.MESINICIO = (int)result.Rows[i]["MESINICIO"];

                lMetasResultDTO.Add(ulMetasResulDTO);
            }

            lFormularioMetasResultDTO.ListMetaResult = lMetasResultDTO;
            return lFormularioMetasResultDTO;
        }

    }

}