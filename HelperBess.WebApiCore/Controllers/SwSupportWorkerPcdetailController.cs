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
    public class SwSupportWorkerPcdetailController : Controller
    {
        private readonly ISwSupportWorkerPcdetailService SwSupportWorkerPcdetailServiceService;
        public SwSupportWorkerPcdetailController(ISwSupportWorkerPcdetailService iSwSupportWorkerPcdetailService)
        {
            SwSupportWorkerPcdetailServiceService = iSwSupportWorkerPcdetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/GetSwSupportWorkerPcdetail")]
        public IEnumerable<SwSupportWorkerPcdetail> GetSwSupportWorkerPcdetail()
        {
            return SwSupportWorkerPcdetailServiceService.GetSwSupportWorkerPcdetail();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/AddSwSupportWorkerPcdetail")]
        public SwSupportWorkerPcdetail AddSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetail)
        {
            return SwSupportWorkerPcdetailServiceService.AddSwSupportWorkerPcdetail(SwSupportWorkerPcdetail);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/UpdateSwSupportWorkerPcdetail")]
        public SwSupportWorkerPcdetail UpdateSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetail)
        {
            return SwSupportWorkerPcdetailServiceService.UpdateSwSupportWorkerPcdetail(SwSupportWorkerPcdetail);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/DeleteSwSupportWorkerPcdetail")]
        public SwSupportWorkerPcdetail DeleteSwSupportWorkerPcdetail(int id)
        {
            return SwSupportWorkerPcdetailServiceService.DeleteSwSupportWorkerPcdetail(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/GetSwSupportWorkerPcdetailById")]
        public SwSupportWorkerPcdetail GetSwSupportWorkerPcdetailById(int id)
        {
            return SwSupportWorkerPcdetailServiceService.GetSwSupportWorkerPcdetailById(id);
        }
    }
}
