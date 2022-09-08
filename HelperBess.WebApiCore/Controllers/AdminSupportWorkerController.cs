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
    public class AdminSupportWorkerController : ControllerBase
    {
        private readonly IAdminSupportWorkerService AdminSupportWorkerServiceService;
        public AdminSupportWorkerController(IAdminSupportWorkerService iAdminSupportWorkerService)
        {
            AdminSupportWorkerServiceService = iAdminSupportWorkerService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/AdminSupportWorker/GetAdminSupportWorker")]
        //[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin": "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public IEnumerable<AdminSupportWorker> GetAdminSupportWorker()
        {
            return AdminSupportWorkerServiceService.GetAdminSupportWorker();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/AdminSupportWorker/AddAdminSupportWorker")]
        public AdminSupportWorker AddAdminSupportWorker(AdminSupportWorker AdminSupportWorker)
        {
            return AdminSupportWorkerServiceService.AddAdminSupportWorker(AdminSupportWorker);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/AdminSupportWorker/UpdateAdminSupportWorker")]
        public AdminSupportWorker UpdateAdminSupportWorker(AdminSupportWorker AdminSupportWorker)
        {
            return AdminSupportWorkerServiceService.UpdateAdminSupportWorker(AdminSupportWorker);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/AdminSupportWorker/DeleteAdminSupportWorker")]
        public AdminSupportWorker DeleteAdminSupportWorker(int id)
        {
            return AdminSupportWorkerServiceService.DeleteAdminSupportWorker(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/AdminSupportWorker/GetAdminSupportWorkerById")]
        public AdminSupportWorker GetAdminSupportWorkerById(int id)
        {
            return AdminSupportWorkerServiceService.GetAdminSupportWorkerById(id);
        }

    }
}
