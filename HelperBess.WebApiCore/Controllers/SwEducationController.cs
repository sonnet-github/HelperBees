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
    public class SwEducationController : ControllerBase
    {
        private readonly ISwEducationService SwEducationServiceService;
        public SwEducationController(ISwEducationService iSwEducationService)
        {
            SwEducationServiceService = iSwEducationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEducation/GetSwEducation")]
        public IEnumerable<SwEducation> GetSwEducation()
        {
            return SwEducationServiceService.GetSwEducation();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwEducation/AddSwEducation")]
        public SwEducation AddSwEducation(SwEducation SwEducation)
        {
            return SwEducationServiceService.AddSwEducation(SwEducation);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwEducation/UpdateSwEducation")]
        public SwEducation UpdateSwEducation(SwEducation SwEducation)
        {
            return SwEducationServiceService.UpdateSwEducation(SwEducation);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwEducation/DeleteSwEducation")]
        public SwEducation DeleteSwEducation(int id)
        {
            return SwEducationServiceService.DeleteSwEducation(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEducation/GetSwEducationById")]
        public SwEducation GetSwEducationById(int id)
        {
            return SwEducationServiceService.GetSwEducationById(id);
        }
    }
}
