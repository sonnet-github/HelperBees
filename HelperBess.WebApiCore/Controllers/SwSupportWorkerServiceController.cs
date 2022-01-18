using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class SwSupportWorkerServiceController : Controller
    {
private readonly ISwSupportWorkerServiceService SwSupportWorkerServiceServiceService;
        public SwSupportWorkerServiceController(ISwSupportWorkerServiceService iSwSupportWorkerServiceService)
        {
            SwSupportWorkerServiceServiceService = iSwSupportWorkerServiceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/GetSwSupportWorkerService")]
        public IEnumerable<SwSupportWorkerService> GetSwSupportWorkerService()
        {
            return SwSupportWorkerServiceServiceService.GetSwSupportWorkerService();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/AddSwSupportWorkerService")]
        public SwSupportWorkerService AddSwSupportWorkerService(SwSupportWorkerService SwSupportWorkerService)
        {
            return SwSupportWorkerServiceServiceService.AddSwSupportWorkerService(SwSupportWorkerService);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/UpdateSwSupportWorkerService")]
        public SwSupportWorkerService UpdateSwSupportWorkerService(SwSupportWorkerService SwSupportWorkerService)
        {
            return SwSupportWorkerServiceServiceService.UpdateSwSupportWorkerService(SwSupportWorkerService);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/DeleteSwSupportWorkerService")]
        public SwSupportWorkerService DeleteSwSupportWorkerService(int id)
        {
            return SwSupportWorkerServiceServiceService.DeleteSwSupportWorkerService(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/GetSwSupportWorkerServiceById")]
        public SwSupportWorkerService GetSwSupportWorkerServiceById(int id)
        {
            return SwSupportWorkerServiceServiceService.GetSwSupportWorkerServiceById(id);
        }
    }
}
