using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Application.Service;
using Metas.Domain;
using Metas.Profile;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    [ApiController]
    [Route("User/")]
    public class UserController : Controller
    {
        private readonly IAplicationServiceUser _applicationServiceUser;

        public UserController(IAplicationServiceUser ApplicationServiceUser)
        {
            this._applicationServiceUser = ApplicationServiceUser;
        }

        private readonly IMemoryCache _memorychache;
        private const string COUNTRYES_KEY = "cc";

        //[Authorize]
        //public ActionResult Usuarios()
        //{
        //    User usuario = new User(1,10,"dd");
        //    usuario.FUNC = 1;
        //    usuario.ID = 10;
        //    usuario.NOME = "dd";

        //    return(usuario);
        //}

        //which user
        [HttpPost]
        [Route("WhichUser")]
        public  Task<int> GetListCiclo()
        {

            var userInfo = new Metas.Profile.pkxd(1, 1, "es", 1, 0);
            {
            };

            var usuario = "Anônimo";
            var autenticado = true;

            usuario = HttpContext.User.Identity.Name;

            //var autenticado = false;
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                usuario = HttpContext.User.Identity.Name;
                autenticado = true;
            }
            else
            {
                usuario = "Não Logado";
                autenticado = false;
            }
                        
            int result =1;

            return Task.FromResult(result);
            
        }

        //[Authorize]
        //public ActionResult Usuarios()
        //{
        //    var usuario = new pkxd(1, 1, "es", 1, 0);
        //    //return usuario();
        //    //return View(usuario.GetUsuarios());
        //}

        // lista tutorial
        [HttpGet]
        [Route("ListTutorial")]
        public async Task<ActionResult> GetTutorialByUser()
        {
            var result = await _applicationServiceUser.OnGetTutorialByUser();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }

        //Cultura
        [HttpGet]
        [Route("Culture")]
        public async Task<ActionResult> GetCulture()
        {
            var result = await _applicationServiceUser.OnGetGetCulture();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
        // Lista notificações do usuário
        [HttpGet]
        [Route("ListNotification")]
        public async Task<ActionResult> GetUserNotification()
        {
            var result = await _applicationServiceUser.OnGetUserNotification();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }

        //Desativa tutorial do usuário
        [HttpPost]
        [Route("DeactiveTutorial")]
        public async Task<ActionResult> DeactiveTutorial(TutorialUsuarioDTO tutorialusuarioDTO)
        {
            try
            {
                if (tutorialusuarioDTO == null)
                    return NotFound();

                await _applicationServiceUser.OnDeactiveTutorial(tutorialusuarioDTO);

                return Ok();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Lista geral de dfrequencia
        [HttpGet]
        [Route("ListFrequency")]
        public async Task<ActionResult> GetListFrequency()
        {
            var result = await _applicationServiceUser.OnGetListFrequency();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // lista geral de unidade de medida
        [HttpGet]
        [Route("ListMeasure")]
        public async Task<ActionResult> GetListMeasure()
        {
            var result = await _applicationServiceUser.OnGetListMeasure();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
