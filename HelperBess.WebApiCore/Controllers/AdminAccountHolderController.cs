using Microsoft.AspNetCore.Mvc;
using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Services
{
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class AdminAccountHolderController : ControllerBase
    {
        private readonly IAdminAccountHolderService AdminAccountHolderServiceService;
        public AdminAccountHolderController(IAdminAccountHolderService iAdminAccountHolderService)
        {
            AdminAccountHolderServiceService = iAdminAccountHolderService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/AdminAccountHolder/GetAdminAccountHolder")]
        //[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin": "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public IEnumerable<AdminAccountHolder> GetAdminAccountHolder()
        {
            return AdminAccountHolderServiceService.GetAdminAccountHolder();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/AdminAccountHolder/AddAdminAccountHolder")]
        public AdminAccountHolder AddAdminAccountHolder(AdminAccountHolder AdminAccountHolder)
        {
            return AdminAccountHolderServiceService.AddAdminAccountHolder(AdminAccountHolder);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/AdminAccountHolder/UpdateAdminAccountHolder")]
        public AdminAccountHolder UpdateAdminAccountHolder(AdminAccountHolder AdminAccountHolder)
        {
            return AdminAccountHolderServiceService.UpdateAdminAccountHolder(AdminAccountHolder);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/AdminAccountHolder/DeleteAdminAccountHolder")]
        public AdminAccountHolder DeleteAdminAccountHolder(int id)
        {
            return AdminAccountHolderServiceService.DeleteAdminAccountHolder(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/AdminAccountHolder/GetAdminAccountHolderById")]
        public AdminAccountHolder GetAdminAccountHolderById(int id)
        {
            return AdminAccountHolderServiceService.GetAdminAccountHolderById(id);
        }
    }
}
