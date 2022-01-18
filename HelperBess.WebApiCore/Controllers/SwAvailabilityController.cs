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
    public class SwAvailabilityController : ControllerBase
    {
        private readonly ISwAvailabilityService SwAvailabilityServiceService;
        public SwAvailabilityController(ISwAvailabilityService iSwAvailabilityService)
        {
            SwAvailabilityServiceService = iSwAvailabilityService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailability/GetSwAvailability")]
        public IEnumerable<SwAvailability> GetSwAvailability()
        {
            return SwAvailabilityServiceService.GetSwAvailability();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwAvailability/AddSwAvailability")]
        public SwAvailability AddSwAvailability(SwAvailability SwAvailability)
        {
            return SwAvailabilityServiceService.AddSwAvailability(SwAvailability);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwAvailability/UpdateSwAvailability")]
        public SwAvailability UpdateSwAvailability(SwAvailability SwAvailability)
        {
            return SwAvailabilityServiceService.UpdateSwAvailability(SwAvailability);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwAvailability/DeleteSwAvailability")]
        public SwAvailability DeleteSwAvailability(int id)
        {
            return SwAvailabilityServiceService.DeleteSwAvailability(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailability/GetSwAvailabilityById")]
        public SwAvailability GetSwAvailabilityById(int id)
        {
            return SwAvailabilityServiceService.GetSwAvailabilityById(id);
        }
    }
}
