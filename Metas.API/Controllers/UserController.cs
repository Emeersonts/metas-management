using Metas.Application.DTO;
using Metas.Application.Interface;
using Metas.Application.Service;
using Metas.Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
            var pk = new Metas.Profile.pkxd(1, 1, "es", 1,0);

            return Task.FromResult(1);
            
        }

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

    }
}
