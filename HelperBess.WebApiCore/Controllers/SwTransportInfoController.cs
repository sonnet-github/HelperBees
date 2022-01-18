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
    public class SwTransportInfoController : ControllerBase
    {
        private readonly ISwTransportInfoService SwTransportInfoServiceService;
        public SwTransportInfoController(ISwTransportInfoService iSwTransportInfoService)
        {
            SwTransportInfoServiceService = iSwTransportInfoService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTransportInfo/GetSwTransportInfo")]
        public IEnumerable<SwTransportInfo> GetSwTransportInfo()
        {
            return SwTransportInfoServiceService.GetSwTransportInfo();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTransportInfo/AddSwTransportInfo")]
        public SwTransportInfo AddSwTransportInfo(SwTransportInfo SwTransportInfo)
        {
            return SwTransportInfoServiceService.AddSwTransportInfo(SwTransportInfo);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTransportInfo/UpdateSwTransportInfo")]
        public SwTransportInfo UpdateSwTransportInfo(SwTransportInfo SwTransportInfo)
        {
            return SwTransportInfoServiceService.UpdateSwTransportInfo(SwTransportInfo);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTransportInfo/DeleteSwTransportInfo")]
        public SwTransportInfo DeleteSwTransportInfo(int id)
        {
            return SwTransportInfoServiceService.DeleteSwTransportInfo(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTransportInfo/GetSwTransportInfoById")]
        public SwTransportInfo GetSwTransportInfoById(int id)
        {
            return SwTransportInfoServiceService.GetSwTransportInfoById(id);
        }
    }
}
