using Microsoft.AspNetCore.Mvc;
using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace HelperBess.WebApiCore.Services
{
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class AdministratorController : ControllerBase
    {
        private readonly IAdministratorService AdministratorServiceService;
        public AdministratorController(IAdministratorService iAdministratorService)
        {
            AdministratorServiceService = iAdministratorService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Administrator/GetAdministrator")]
        //[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin": "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public IEnumerable<Administrator> GetAdministrator()
        {
            return AdministratorServiceService.GetAdministrator();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Administrator/AddAdministrator")]
        public Administrator AddAdministrator(Administrator Administrator)
        {
            return AdministratorServiceService.AddAdministrator(Administrator);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Administrator/UpdateAdministrator")]
        public Administrator UpdateAdministrator(Administrator Administrator)
        {
            return AdministratorServiceService.UpdateAdministrator(Administrator);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Administrator/DeleteAdministrator")]
        public Administrator DeleteAdministrator(int id)
        {
            return AdministratorServiceService.DeleteAdministrator(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Administrator/GetAdministratorById")]
        public Administrator GetAdministratorById(int id)
        {
            return AdministratorServiceService.GetAdministratorById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Administrator/GetAdministratorByEmail")]
        public IActionResult GetAdministratorByEmail(string EmailAddress)
        {
            try
            {
                Administrator administrator = AdministratorServiceService.GetAdministratorByEmail(EmailAddress);


                if (administrator != null)
                {
                    return Ok(administrator);
                }
                else
                {
                    return BadRequest("administrator emailaddress not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

           
        }

    }
}
