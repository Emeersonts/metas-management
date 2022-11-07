using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.DomainCore.Service;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplicationServiceRH : IAplicationServiceRH
    {

        private readonly IServiceRH _ServiceRH;
        public AplicationServiceRH(IServiceRH serviceRH)
        {
            this._ServiceRH = serviceRH;
        }

        public async Task<FormCelulaTrabalhoDTO> onGetListCelula(int IDREPRESENTANTE)
        {
            var result = await _ServiceRH.GetListCelula(IDREPRESENTANTE);

            FormCelulaTrabalhoDTO listcelulatrabalho = new FormCelulaTrabalhoDTO();
            List<CelulatrabalhoDTO> lcelula = new List<CelulatrabalhoDTO>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                CelulatrabalhoDTO ucicloDTO = new CelulatrabalhoDTO();

                ucicloDTO.IDCELULATRABALHO = (int)result.Rows[i]["IDCELULATRABALHO"];
                ucicloDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();

                lcelula.Add(ucicloDTO);

            }
            listcelulatrabalho.ListCelulaTrabalho = lcelula;

            return listcelulatrabalho;
        }

        public async Task<ForDropGestorDTO> onGetListGestor()
        {
            var result = await _ServiceRH.GetListGestor();

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

        public async Task<ForMetaRelatorioDTO> onGetMetaSimulate(int anocilco, int idcelulatrabalho, int mes)
        {
            ForMetaRelatorioDTO lForIndicador = new ForMetaRelatorioDTO();

            var resultIndicador = await _ServiceRH.GetMetaSimulate(anocilco,idcelulatrabalho,mes);
            List<MetasDTO> lIndicador = new List<MetasDTO>();

            for (int J = 0; J < resultIndicador.Rows.Count; J++)
            {
                MetasDTO uLindicador = new MetasDTO();

                uLindicador.NOMEINDICADOR = resultIndicador.Rows[J]["NOMEINDICADOR"].ToString();
                uLindicador.NOMEUNIDADEMEDIDA = resultIndicador.Rows[J]["NOMEUNIDADEMEDIDA"].ToString();
                uLindicador.DESCRICAO = resultIndicador.Rows[J]["DESCRICAO"].ToString();
                uLindicador.PESO = (int)resultIndicador.Rows[J]["PESO"];
                uLindicador.MINIMO = (decimal)resultIndicador.Rows[J]["MINIMO"];
                uLindicador.PLANEJADO = (decimal)resultIndicador.Rows[J]["PLANEJADO"];
                uLindicador.DESAFIO = (decimal)resultIndicador.Rows[J]["DESAFIO"];
                uLindicador.RESULTADOAPURADO = (decimal)resultIndicador.Rows[J]["RESULTADOAPURADO"];
                uLindicador.IDINDICADOR = (int)resultIndicador.Rows[J]["IDINDICADOR"];

                lIndicador.Add(uLindicador);
            }

            lForIndicador.ListMeta = lIndicador;

            return lForIndicador;
        }

        public async Task<RepresentanteDTO> onGetVerifyRepresentantative(int anocilco, int idcelulatrabalho)
        {
            var result = await _ServiceRH.GetVerifyRepresentantative(anocilco, idcelulatrabalho);

            RepresentanteDTO Representante = new RepresentanteDTO();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                Representante.Id = (int)result.Rows[i]["IDREPRESENTANTE"];
                Representante.Nome = result.Rows[i]["NOMECOMPLETO"].ToString();
            }

            return Representante;
        }
    }
}
