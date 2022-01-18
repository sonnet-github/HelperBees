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
    public class SwSupportWorkerAhdetailController : ControllerBase
    {
        private readonly ISwSupportWorkerAhdetailService SwSupportWorkerAhdetailServiceService;
        public SwSupportWorkerAhdetailController(ISwSupportWorkerAhdetailService iSwSupportWorkerAhdetailService)
        {
            SwSupportWorkerAhdetailServiceService = iSwSupportWorkerAhdetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/GetSwSupportWorkerAhdetail")]
        public IEnumerable<SwSupportWorkerAhdetail> GetSwSupportWorkerAhdetail()
        {
            return SwSupportWorkerAhdetailServiceService.GetSwSupportWorkerAhdetail();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/AddSwSupportWorkerAhdetail")]
        public SwSupportWorkerAhdetail AddSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetail)
        {
            return SwSupportWorkerAhdetailServiceService.AddSwSupportWorkerAhdetail(SwSupportWorkerAhdetail);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/UpdateSwSupportWorkerAhdetail")]
        public SwSupportWorkerAhdetail UpdateSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetail)
        {
            return SwSupportWorkerAhdetailServiceService.UpdateSwSupportWorkerAhdetail(SwSupportWorkerAhdetail);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/DeleteSwSupportWorkerAhdetail")]
        public SwSupportWorkerAhdetail DeleteSwSupportWorkerAhdetail(int id)
        {
            return SwSupportWorkerAhdetailServiceService.DeleteSwSupportWorkerAhdetail(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/GetSwSupportWorkerAhdetailById")]
        public SwSupportWorkerAhdetail GetSwSupportWorkerAhdetailById(int id)
        {
            return SwSupportWorkerAhdetailServiceService.GetSwSupportWorkerAhdetailById(id);
        }
    }
}
