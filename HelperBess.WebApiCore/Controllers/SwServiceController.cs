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
    public class SwServiceController : ControllerBase
    {
        private readonly ISwServiceService SwServiceServiceService;
        public SwServiceController(ISwServiceService iSwServiceService)
        {
            SwServiceServiceService = iSwServiceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwService/GetSwService")]
        public IEnumerable<SwService> GetSwService()
        {
            return SwServiceServiceService.GetSwService();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwService/AddSwService")]
        public SwService AddSwService(SwService SwService)
        {
            return SwServiceServiceService.AddSwService(SwService);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwService/UpdateSwService")]
        public SwService UpdateSwService(SwService SwService)
        {
            return SwServiceServiceService.UpdateSwService(SwService);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwService/DeleteSwService")]
        public SwService DeleteSwService(int id)
        {
            return SwServiceServiceService.DeleteSwService(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwService/GetSwServiceById")]
        public SwService GetSwServiceById(int id)
        {
            return SwServiceServiceService.GetSwServiceById(id);
        }
    }
}
