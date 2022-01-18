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
    public class SwSupportWorkerReligionController : ControllerBase
    {
        private readonly ISwSupportWorkerReligionService SwSupportWorkerReligionServiceService;
        public SwSupportWorkerReligionController(ISwSupportWorkerReligionService iSwSupportWorkerReligionService)
        {
            SwSupportWorkerReligionServiceService = iSwSupportWorkerReligionService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/GetSwSupportWorkerReligion")]
        public IEnumerable<SwSupportWorkerReligion> GetSwSupportWorkerReligion()
        {
            return SwSupportWorkerReligionServiceService.GetSwSupportWorkerReligion();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/AddSwSupportWorkerReligion")]
        public SwSupportWorkerReligion AddSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligion)
        {
            return SwSupportWorkerReligionServiceService.AddSwSupportWorkerReligion(SwSupportWorkerReligion);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/UpdateSwSupportWorkerReligion")]
        public SwSupportWorkerReligion UpdateSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligion)
        {
            return SwSupportWorkerReligionServiceService.UpdateSwSupportWorkerReligion(SwSupportWorkerReligion);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/DeleteSwSupportWorkerReligion")]
        public SwSupportWorkerReligion DeleteSwSupportWorkerReligion(int id)
        {
            return SwSupportWorkerReligionServiceService.DeleteSwSupportWorkerReligion(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/GetSwSupportWorkerReligionById")]
        public SwSupportWorkerReligion GetSwSupportWorkerReligionById(int id)
        {
            return SwSupportWorkerReligionServiceService.GetSwSupportWorkerReligionById(id);
        }
    }
}
