using DocumentFormat.OpenXml.Office2010.Excel;
using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using Metas.DomainCore.Service;
using Metas.Profile;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

            String descricaostatus = "";
            int idstatuscilo = 0;
            
            for (int J = 0; J < resultIndicador.Rows.Count; J++)
            {
                MetasDTO uLindicador = new MetasDTO();

                uLindicador.NOMEINDICADOR = resultIndicador.Rows[J]["NOMEINDICADOR"].ToString();
                uLindicador.NOMEUNIDADEMEDIDA = resultIndicador.Rows[J]["NOMEUNIDADEMEDIDA"].ToString();
                uLindicador.DESCRICAO = resultIndicador.Rows[J]["DESCRICAO"].ToString();
                uLindicador.PESO = (int)resultIndicador.Rows[J]["PESO"];
                uLindicador.ORDEMINICIO = (int)resultIndicador.Rows[J]["ORDEMINICIO"];
                uLindicador.MINIMO = (decimal)resultIndicador.Rows[J]["MINIMO"];
                uLindicador.PLANEJADO = (decimal)resultIndicador.Rows[J]["PLANEJADO"];
                uLindicador.DESAFIO = (decimal)resultIndicador.Rows[J]["DESAFIO"];
                uLindicador.RESULTADOAPURADO = (decimal)resultIndicador.Rows[J]["RESULTADOAPURADO"];
                uLindicador.IDINDICADOR = (int)resultIndicador.Rows[J]["IDINDICADOR"];
                descricaostatus = resultIndicador.Rows[J]["DESCRICAOSTATUS"].ToString();
                idstatuscilo = (int)resultIndicador.Rows[J]["IDSTATUSCICLO"];

                lIndicador.Add(uLindicador);
            }

            lForIndicador.ListMeta = lIndicador;
            lForIndicador.IDSTATUSCICLO = idstatuscilo;
            lForIndicador.DESCRICAOSTATUS = descricaostatus;

            return lForIndicador;
        }

        public async Task<RepresentanteDTO> onGetVerifyRepresentantative(int idcelulatrabalho)
        {
            var result = await _ServiceRH.GetVerifyRepresentantative(idcelulatrabalho);

            RepresentanteDTO Representante = new RepresentanteDTO();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                Representante.IDREPRESENTANTE = (int)result.Rows[i]["IDREPRESENTANTE"];
                Representante.NOMEREPRESENTANTE = result.Rows[i]["NOMEREPRESENTANTE"].ToString();

                Representante.IDSUPLENTE = (int)result.Rows[i]["IDSUPLENTE"];
                Representante.NOMESUPLENTE = result.Rows[i]["NOMESUPLENTE"].ToString();

                Representante.IDGESTOR = (int)result.Rows[i]["IDGESTOR"];
                Representante.NOMEGESTOR = result.Rows[i]["NOMEGESTOR"].ToString();

            }

            return Representante;
        }


        public async  Task<FormGestorStatusDTO> onGetMetaMmanagerStatus(int anociclo, int pagina, int qtpagina, string busca)
        {
            FormGestorStatusDTO lForIndicador = new FormGestorStatusDTO();

            var resultIndicador = await _ServiceRH.GetMetaMmanagerStatus(anociclo, pagina, qtpagina, busca);
            List<GestorStatusDTO> lIndicador = new List<GestorStatusDTO>();

            int qtp = 0;
            int totregistro = 0;
            
            for (int J = 0; J < resultIndicador.Rows.Count; J++)
            {
                GestorStatusDTO uLindicador = new GestorStatusDTO();

                uLindicador.DATASTATUS = Convert.ToDateTime(resultIndicador.Rows[J]["DATASTATUS"]);

                uLindicador.NPESSOAL = (int)resultIndicador.Rows[J]["NPESSOAL"];
                uLindicador.RITMO = (int)resultIndicador.Rows[J]["RITMO"];
                uLindicador.DESCRICAOSTATUS = resultIndicador.Rows[J]["DESCRICAOSTATUS"].ToString();
                uLindicador.NOMEFORMULARIO = resultIndicador.Rows[J]["DESCRICAOCELULA"].ToString();
                uLindicador.NOMECOMPLETO = resultIndicador.Rows[J]["NOMECOMPLETO"].ToString();
                uLindicador.NPESSOAL = (int)resultIndicador.Rows[J]["NPESSOAL"];
                uLindicador.IDCELULATRABALHO = (int)resultIndicador.Rows[J]["IDCELULATRABALHO"];
                totregistro = (int)resultIndicador.Rows[J]["TOTALREGISTRO"];
                qtp = (int)resultIndicador.Rows[J]["PG"];
                uLindicador.ATA = resultIndicador.Rows[J]["ATA"].ToString();

                lIndicador.Add(uLindicador);
            }

            lForIndicador.QTPAGINA = qtp;
            lForIndicador.TOTALREGISTRO = totregistro;
            lForIndicador.Listform = lIndicador;

            return lForIndicador;
        }

        public async Task<FormDropColaboradorDTO> onDropCollaborator()
        {
            FormDropColaboradorDTO lcolaborador = new FormDropColaboradorDTO();
            List<DropColaboradorDTO> lcol = new List<DropColaboradorDTO>();

            var resultIndicador = await _ServiceRH.GetDropCollaborator();


            for (int J = 0; J < resultIndicador.Rows.Count; J++)
            {
                DropColaboradorDTO uLindicador = new DropColaboradorDTO();

                uLindicador.NPESSOAL = (int)resultIndicador.Rows[J]["NPESSOAL"];
                uLindicador.NOMECOMPLETO = resultIndicador.Rows[J]["NOME"].ToString();

                lcol.Add(uLindicador);
            }

            lcolaborador.Listform = lcol;

            return lcolaborador;
        }

        public async Task<FormDropColaboradorDTO> onDropEqipCollaborator(int idcelulatrabalho)
        {
            FormDropColaboradorDTO lcolaborador = new FormDropColaboradorDTO();
            List<DropColaboradorDTO> lcol = new List<DropColaboradorDTO>();

            var resultIndicador = await _ServiceRH.GetDropEqipCollaborator(idcelulatrabalho);


            for (int J = 0; J < resultIndicador.Rows.Count; J++)
            {
                DropColaboradorDTO uLindicador = new DropColaboradorDTO();

                uLindicador.NPESSOAL = (int)resultIndicador.Rows[J]["NPESSOAL"];
                uLindicador.NOMECOMPLETO = resultIndicador.Rows[J]["NOME"].ToString();

                lcol.Add(uLindicador);
            }

            lcolaborador.Listform = lcol;

            return lcolaborador;
        }
    }
}
