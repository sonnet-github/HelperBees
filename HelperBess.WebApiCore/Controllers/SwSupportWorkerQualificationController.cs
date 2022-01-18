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
    public class SwSupportWorkerQualificationController : ControllerBase
    {
        private readonly ISwSupportWorkerQualificationService SwSupportWorkerQualificationServiceService;
        public SwSupportWorkerQualificationController(ISwSupportWorkerQualificationService iSwSupportWorkerQualificationService)
        {
            SwSupportWorkerQualificationServiceService = iSwSupportWorkerQualificationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/GetSwSupportWorkerQualification")]
        public IEnumerable<SwSupportWorkerQualification> GetSwSupportWorkerQualification()
        {
            return SwSupportWorkerQualificationServiceService.GetSwSupportWorkerQualification();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/AddSwSupportWorkerQualification")]
        public SwSupportWorkerQualification AddSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification)
        {
            return SwSupportWorkerQualificationServiceService.AddSwSupportWorkerQualification(SwSupportWorkerQualification);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/UpdateSwSupportWorkerQualification")]
        public SwSupportWorkerQualification UpdateSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification)
        {
            return SwSupportWorkerQualificationServiceService.UpdateSwSupportWorkerQualification(SwSupportWorkerQualification);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/DeleteSwSupportWorkerQualification")]
        public SwSupportWorkerQualification DeleteSwSupportWorkerQualification(int id)
        {
            return SwSupportWorkerQualificationServiceService.DeleteSwSupportWorkerQualification(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/GetSwSupportWorkerQualificationById")]
        public SwSupportWorkerQualification GetSwSupportWorkerQualificationById(int id)
        {
            return SwSupportWorkerQualificationServiceService.GetSwSupportWorkerQualificationById(id);
        }
    }
}
