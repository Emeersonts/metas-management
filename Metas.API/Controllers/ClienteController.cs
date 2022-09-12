using Metas.Application.DTO;
using Metas.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Metas.API.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("Cliente/")]
    public class ClienteController : Controller
    {

        private readonly IAplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IAplicationServiceCliente ApplicationServiceCliente)
        {
            this._applicationServiceCliente = ApplicationServiceCliente;
        }

        //private readonly IApprovalPresenter approvalPresenter;

        //public ApprovalController(IApprovalPresenter approvalPresenter)
        //{
        //    this.approvalPresenter = approvalPresenter;
        //}




        //[HttpPost]
        //public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        //{
        //   // var clienteDTO = _applicationServiceCliente.Add(obj);

        //}

        //    [HttpPost]
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }

        //    [HttpGet]
        //    public ActionResult<IEnumerable<string>> Get()
        //    {
        //        return Ok(_applicationServiceCliente.Getall());
        //    }


        /// <summary>
        /// lista de documentos
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddCliente")]
        //[ResponseType(typeof(int))]
        //[SwaggerResponse(HttpStatusCode.OK, "Endpoint para cadastrar a campanha", Type = typeof(int))]
        //[SwaggerResponse((int)HttpStatusCode.OK, "Endpoint para cadastrar um novo cliente")]
        public async Task<ActionResult> AddCliente (ClienteDTO clienteDTO)
        //public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        //public async Task<IHttpActionResult> Campaigns(ApprovalListParameterDTO parameters)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                //var pk = new Metas.Profile.pkxd(1, 1, "es", 1);

                //Metas.Profile.pkxd hh = new Metas.Profile.pkxd(1,1,"es",1);
                

                //var result = await approvalPresenter.OnFindApprovalBy(parameters);
                //var gg = _applicationServiceCliente.OnAddCliente(clienteDTO);
                var ghh =  await _applicationServiceCliente.OnAddCliente(clienteDTO);

                //var result = await _applicationServiceCliente.OnDecline(clienteDTO);

                //var result = await _applicationServiceCliente.Add(clienteDTO);
                if (ghh==0)
                {
                    return Ok("Cliente Cadastrado com sucesso!");
                }
                else
                {  // classe de erro
                    return Ok("Cli não Cadastrado com sucesso!");
                }
                

                //await userProfilePresenter.OnSaveUser(user);
                //return Ok();

                //await _applicationServiceCliente.OnAddCliente(clienteDTO);
                //return Ok();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
