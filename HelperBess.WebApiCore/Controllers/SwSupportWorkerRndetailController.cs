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
    public class SwSupportWorkerRndetailController : Controller
    {
        private readonly ISwSupportWorkerRndetailService SwSupportWorkerRndetailServiceService;
        public SwSupportWorkerRndetailController(ISwSupportWorkerRndetailService iSwSupportWorkerRndetailService)
        {
            SwSupportWorkerRndetailServiceService = iSwSupportWorkerRndetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/GetSwSupportWorkerRndetail")]
        public IEnumerable<SwSupportWorkerRndetail> GetSwSupportWorkerRndetail()
        {
            return SwSupportWorkerRndetailServiceService.GetSwSupportWorkerRndetail();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/AddSwSupportWorkerRndetail")]
        public SwSupportWorkerRndetail AddSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetail)
        {
            return SwSupportWorkerRndetailServiceService.AddSwSupportWorkerRndetail(SwSupportWorkerRndetail);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/UpdateSwSupportWorkerRndetail")]
        public SwSupportWorkerRndetail UpdateSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetail)
        {
            return SwSupportWorkerRndetailServiceService.UpdateSwSupportWorkerRndetail(SwSupportWorkerRndetail);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/DeleteSwSupportWorkerRndetail")]
        public SwSupportWorkerRndetail DeleteSwSupportWorkerRndetail(int id)
        {
            return SwSupportWorkerRndetailServiceService.DeleteSwSupportWorkerRndetail(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/GetSwSupportWorkerRndetailById")]
        public SwSupportWorkerRndetail GetSwSupportWorkerRndetailById(int id)
        {
            return SwSupportWorkerRndetailServiceService.GetSwSupportWorkerRndetailById(id);
        }
    }
}
