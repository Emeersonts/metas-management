using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.DomainCore.Interface;
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

        public async Task<ForMetaRelatorioDTO> OnGetTeam(int CICLO)
        {
            ForMetaRelatorioDTO LForMetarelatorio = new ForMetaRelatorioDTO();

            var resultAfast = await _ServiceGestor.GetGoalsReport(CICLO);
            List<MetasDTO> Imeta = new List<MetasDTO>();

            for (int J = 0; J < resultAfast.Rows.Count; J++)
            {
                MetasDTO uMeta = new MetasDTO();
                uMeta.NOMEINDICADOR = resultAfast.Rows[J]["NOMEINDICADOR"].ToString();
                uMeta.NOMEUNIDADEMEDIDA = resultAfast.Rows[J]["NOMEUNIDADEMEDIDA"].ToString();
                uMeta.DESCRICAO = resultAfast.Rows[J]["DESCRICAO"].ToString();
                uMeta.PESO = (decimal)resultAfast.Rows[J]["PESO"];
                uMeta.MINIMO = (decimal)resultAfast.Rows[J]["MINIMO"];
                if (resultAfast.Rows[J]["RESULTADOAPURADO"] != DBNull.Value) { uMeta.RESULTADOAPURADO = (decimal)resultAfast.Rows[J]["RESULTADOAPURADO"]; }
                if (resultAfast.Rows[J]["SIMULADOAPURADO"] != DBNull.Value) { uMeta.SIMULADOAPURADO = (decimal)resultAfast.Rows[J]["SIMULADOAPURADO"]; }
                uMeta.MESINICIO = (int)resultAfast.Rows[J]["MES"];
                
                Imeta.Add(uMeta);

            }

            LForMetarelatorio.ListMeta = Imeta;

            return LForMetarelatorio;

        }
        
    }
}
