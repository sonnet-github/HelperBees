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
    public class SwAvailabilityDetailController : ControllerBase
    {
        private readonly ISwAvailabilityDetailService SwAvailabilityDetailServiceService;
        public SwAvailabilityDetailController(ISwAvailabilityDetailService iSwAvailabilityDetailService)
        {
            SwAvailabilityDetailServiceService = iSwAvailabilityDetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/GetSwAvailabilityDetail")]
        public IEnumerable<SwAvailabilityDetail> GetSwAvailabilityDetail()
        {
            return SwAvailabilityDetailServiceService.GetSwAvailabilityDetail();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/AddSwAvailabilityDetail")]
        public SwAvailabilityDetail AddSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetail)
        {
            return SwAvailabilityDetailServiceService.AddSwAvailabilityDetail(SwAvailabilityDetail);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/UpdateSwAvailabilityDetail")]
        public SwAvailabilityDetail UpdateSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetail)
        {
            return SwAvailabilityDetailServiceService.UpdateSwAvailabilityDetail(SwAvailabilityDetail);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/DeleteSwAvailabilityDetail")]
        public SwAvailabilityDetail DeleteSwAvailabilityDetail(int id)
        {
            return SwAvailabilityDetailServiceService.DeleteSwAvailabilityDetail(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/GetSwAvailabilityDetailById")]
        public SwAvailabilityDetail GetSwAvailabilityDetailById(int id)
        {
            return SwAvailabilityDetailServiceService.GetSwAvailabilityDetailById(id);
        }
    }
}
