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
    public class SwQualificationController : ControllerBase
    {
        private readonly ISwQualificationService SwQualificationServiceService;
        public SwQualificationController(ISwQualificationService iSwQualificationService)
        {
            SwQualificationServiceService = iSwQualificationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwQualification/GetSwQualification")]
        public IEnumerable<SwQualification> GetSwQualification()
        {
            return SwQualificationServiceService.GetSwQualification();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwQualification/AddSwQualification")]
        public SwQualification AddSwQualification(SwQualification SwQualification)
        {
            return SwQualificationServiceService.AddSwQualification(SwQualification);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwQualification/UpdateSwQualification")]
        public SwQualification UpdateSwQualification(SwQualification SwQualification)
        {
            return SwQualificationServiceService.UpdateSwQualification(SwQualification);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwQualification/DeleteSwQualification")]
        public SwQualification DeleteSwQualification(int id)
        {
            return SwQualificationServiceService.DeleteSwQualification(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwQualification/GetSwQualificationById")]
        public SwQualification GetSwQualificationById(int id)
        {
            return SwQualificationServiceService.GetSwQualificationById(id);
        }
    }
}
