using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Domain;
using Metas.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Service
{
    public class AplicationServiceUser : IAplicationServiceUser
    {
        private readonly IServiceUser _ServiceUser;
        public AplicationServiceUser(IServiceUser serviceUser)
        {
            this._ServiceUser = serviceUser;
        }

        public async Task OnDeactiveTutorial(TutorialUsuarioDTO dto)
        {
            var tutorialusuario = new TutorialUsuario(dto.IDPERFIL);

            await _ServiceUser.DeactiveTutorial(tutorialusuario);
        }

        public async Task<ListUnidadeMedidaDTO> OnGetListMeasure()
        {
            var result = await _ServiceUser.GetListMeasure();

            ListUnidadeMedidaDTO listunidademedida = new ListUnidadeMedidaDTO();
            List<UnidadeMedida> lunidademedida = new List<UnidadeMedida>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                UnidadeMedida unidademedidaDTO = new UnidadeMedida();

                unidademedidaDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                unidademedidaDTO.IDUNIDADEMEDIDA = (int)result.Rows[i]["IDUNIDADEMEDIDA"];
                unidademedidaDTO.NOME = result.Rows[i]["NOME"].ToString();

                lunidademedida.Add(unidademedidaDTO);
            }

            listunidademedida.ListUnidadeMedida = lunidademedida;

            return listunidademedida;
        }

        public async Task<LisTutorialDTO> OnGetTutorialByUser()
        {
            var result = await _ServiceUser.GetTutorialByUser();

            LisTutorialDTO listtutorial = new LisTutorialDTO();
            List<Tutorial> ltutorial = new List<Tutorial>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                Tutorial ututorialDTO = new Tutorial();

                ututorialDTO.ENDERECO = result.Rows[i]["ENDERECO"].ToString();
                ututorialDTO.IDPERFIL = (int)result.Rows[i]["IDPERFIL"];
                ututorialDTO.TITULO = result.Rows[i]["TITULO"].ToString();

                ltutorial.Add(ututorialDTO);

            }

            listtutorial.ListTutorial = ltutorial;

            return listtutorial;

        }

        public async Task<ListNotificacaoDTO> OnGetUserNotification()
        {
            var result = await _ServiceUser.GetUserNotification();

            ListNotificacaoDTO listnotificacao = new ListNotificacaoDTO();
            List<Notificacao> lnotificacao = new List<Notificacao>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                Notificacao ututorialDTO = new Notificacao();

                ututorialDTO.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                ututorialDTO.TITULO = result.Rows[i]["TITULO"].ToString();
                ututorialDTO.IDNOTIFICACAO = (int)result.Rows[i]["IDNOTIFICACAO"];
                ututorialDTO.PRAZO = (DateTime)result.Rows[i]["PRAZO"];
                ututorialDTO.DATAPOSTAL = (DateTime)result.Rows[i]["DATAPOSTAL"];

                lnotificacao.Add(ututorialDTO);

            }

            listnotificacao.ListNotificacao = lnotificacao;

            return listnotificacao;
        }

        async Task<ListFrequenciaDTO> IAplicationServiceUser.OnGetListFrequency()
        {
            var result = await _ServiceUser.GetListFrequency();

            ListFrequenciaDTO listfrequencia = new ListFrequenciaDTO();
            List<Frequencia> lfrequencia = new List<Frequencia>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                Frequencia ufreuencia = new Frequencia();

                ufreuencia.DESCRICAO = result.Rows[i]["DESCRICAO"].ToString();
                ufreuencia.IDFREQUENCIA = (int)result.Rows[i]["IDFREQUENCIA"];

                lfrequencia.Add(ufreuencia);

            }
            listfrequencia.ListFrequencia = lfrequencia;

            return listfrequencia;
        }


    }
}
