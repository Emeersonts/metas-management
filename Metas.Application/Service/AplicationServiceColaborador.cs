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

        public async Task<FormularioResultadoMeta> OnGetFindAfastamento(CicloUsuarioDTO dto)
        {
            FormularioResultadoMeta lFormularioResultadoMetasDTO = new FormularioResultadoMeta();

            var resultAfast = await _ServiceColaborador.GetFindAfastamento(new SearchcColaborador(dto.ANOCICLO));
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
            int idstatus = 0;
            string nomestatus = "";

            var result = await _ServiceColaborador.GetFindMeta(new SearchcColaborador(dto.ANOCICLO, dto.MES));

            FormularioMetasDTO lFormularioMetasDTO = new FormularioMetasDTO();
            List<MetasDTO> lMetasDTO = new List<MetasDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                MetasDTO ulMetasDTO = new MetasDTO();
                ulMetasDTO.IDCELULATRABALHO = (int)result.Rows[i]["IDCELULATRABALHO"];
                ulMetasDTO.MESINICIO = (int)result.Rows[i]["MESINICIO"];
                ulMetasDTO.NOMEFORMULARIO = result.Rows[i]["NOMEFORMULARIO"].ToString();
                ulMetasDTO.NOMEINDICADOR = result.Rows[i]["NOMEINDICADOR"].ToString();
                ulMetasDTO.IDINDICADOR= (int)result.Rows[i]["IDINDICADOR"];
                ulMetasDTO.NOMEUNIDADEMEDIDA= result.Rows[i]["NOMEUNIDADEMEDIDA"].ToString();
                ulMetasDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                ulMetasDTO.PESO = (decimal)result.Rows[i]["PESO"];
                ulMetasDTO.MINIMO =  (decimal)result.Rows[i]["MINIMO"];
                ulMetasDTO.PLANEJADO  = (decimal)result.Rows[i]["PLANEJADO"];
                ulMetasDTO.DESAFIO= (decimal)result.Rows[i]["DESAFIO"];
                if (result.Rows[i]["RESULTADOAPURADO"] != DBNull.Value)  { ulMetasDTO.RESULTADOAPURADO = (decimal)result.Rows[i]["RESULTADOAPURADO"];}
                if (result.Rows[i]["SIMULADOAPURADO"] != DBNull.Value) { ulMetasDTO.SIMULADOAPURADO = (decimal)result.Rows[i]["SIMULADOAPURADO"]; }
                if (result.Rows[i]["DATAAPURACAO"] != DBNull.Value) { ulMetasDTO.DATAAPURACAO = (DateTime)result.Rows[i]["DATAAPURACAO"]; }
                if (i ==0)
                {
                    idstatus = (int)result.Rows[i]["IDSTATUS"];
                    nomestatus = result.Rows[i]["NOMESTATUS"].ToString();
                }

                lMetasDTO.Add(ulMetasDTO);
            }

            lFormularioMetasDTO.idstatus = idstatus;
            lFormularioMetasDTO.nomestatus = nomestatus;

            lFormularioMetasDTO.ListMeta = lMetasDTO;
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