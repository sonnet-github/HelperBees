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
    public class SwClientController : ControllerBase
    {
        private readonly ISwClientService SwClientServiceService;
        public SwClientController(ISwClientService iSwClientService)
        {
            SwClientServiceService = iSwClientService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwClient/GetSwClient")]
        public IEnumerable<SwClient> GetSwClient()
        {
            return SwClientServiceService.GetSwClient();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwClient/AddSwClient")]
        public SwClient AddSwClient(SwClient SwClient)
        {
            return SwClientServiceService.AddSwClient(SwClient);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwClient/UpdateSwClient")]
        public SwClient UpdateSwClient(SwClient SwClient)
        {
            return SwClientServiceService.UpdateSwClient(SwClient);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwClient/DeleteSwClient")]
        public SwClient DeleteSwClient(int id)
        {
            return SwClientServiceService.DeleteSwClient(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwClient/GetSwClientById")]
        public SwClient GetSwClientById(int id)
        {
            return SwClientServiceService.GetSwClientById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwClient/GetSwClientBySupportWorkerId")]
        public IEnumerable<SwClient> GetSwClientBySupportWorkerId(int supportWorkerId)
        {
            return SwClientServiceService.GetSwClientBySupportWorkerId(supportWorkerId);
        }
    }
}
