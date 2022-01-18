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
    public class SwSupportWorkerPresignController : ControllerBase
    {
        private readonly ISwSupportWorkerPresignService SwSupportWorkerPresignServiceService;
        public SwSupportWorkerPresignController(ISwSupportWorkerPresignService iSwSupportWorkerPresignService)
        {
            SwSupportWorkerPresignServiceService = iSwSupportWorkerPresignService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/GetSwSupportWorkerPresign")]
        public IEnumerable<SwSupportWorkerPresign> GetSwSupportWorkerPresign()
        {
            return SwSupportWorkerPresignServiceService.GetSwSupportWorkerPresign();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/AddSwSupportWorkerPresign")]
        public SwSupportWorkerPresign AddSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresign)
        {
            return SwSupportWorkerPresignServiceService.AddSwSupportWorkerPresign(SwSupportWorkerPresign);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/UpdateSwSupportWorkerPresign")]
        public SwSupportWorkerPresign UpdateSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresign)
        {
            return SwSupportWorkerPresignServiceService.UpdateSwSupportWorkerPresign(SwSupportWorkerPresign);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/DeleteSwSupportWorkerPresign")]
        public SwSupportWorkerPresign DeleteSwSupportWorkerPresign(int id)
        {
            return SwSupportWorkerPresignServiceService.DeleteSwSupportWorkerPresign(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/GetSwSupportWorkerPresignById")]
        public SwSupportWorkerPresign GetSwSupportWorkerPresignById(int id)
        {
            return SwSupportWorkerPresignServiceService.GetSwSupportWorkerPresignById(id);
        }
    }
}
