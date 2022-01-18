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
    public class SwSupportWorkerOtherQualificationController : ControllerBase
    {
        private readonly ISwSupportWorkerOtherQualificationService SwSupportWorkerOtherQualificationServiceService;
        public SwSupportWorkerOtherQualificationController(ISwSupportWorkerOtherQualificationService iSwSupportWorkerOtherQualificationService)
        {
            SwSupportWorkerOtherQualificationServiceService = iSwSupportWorkerOtherQualificationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/GetSwSupportWorkerOtherQualification")]
        public IEnumerable<SwSupportWorkerOtherQualification> GetSwSupportWorkerOtherQualification()
        {
            return SwSupportWorkerOtherQualificationServiceService.GetSwSupportWorkerOtherQualification();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/AddSwSupportWorkerOtherQualification")]
        public SwSupportWorkerOtherQualification AddSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualification)
        {
            return SwSupportWorkerOtherQualificationServiceService.AddSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/UpdateSwSupportWorkerOtherQualification")]
        public SwSupportWorkerOtherQualification UpdateSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualification)
        {
            return SwSupportWorkerOtherQualificationServiceService.UpdateSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/DeleteSwSupportWorkerOtherQualification")]
        public SwSupportWorkerOtherQualification DeleteSwSupportWorkerOtherQualification(int id)
        {
            return SwSupportWorkerOtherQualificationServiceService.DeleteSwSupportWorkerOtherQualification(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/GetSwSupportWorkerOtherQualificationById")]
        public SwSupportWorkerOtherQualification GetSwSupportWorkerOtherQualificationById(int id)
        {
            return SwSupportWorkerOtherQualificationServiceService.GetSwSupportWorkerOtherQualificationById(id);
        }
    }
}
