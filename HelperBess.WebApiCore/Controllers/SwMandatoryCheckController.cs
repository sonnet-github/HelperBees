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
    public class SwMandatoryCheckController : ControllerBase
    {
        private readonly ISwMandatoryCheckService SwMandatoryCheckServiceService;
        public SwMandatoryCheckController(ISwMandatoryCheckService iSwMandatoryCheckService)
        {
            SwMandatoryCheckServiceService = iSwMandatoryCheckService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwMandatoryCheck/GetSwMandatoryCheck")]
        public IEnumerable<SwMandatoryCheck> GetSwMandatoryCheck()
        {
            return SwMandatoryCheckServiceService.GetSwMandatoryCheck();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwMandatoryCheck/AddSwMandatoryCheck")]
        public SwMandatoryCheck AddSwMandatoryCheck(SwMandatoryCheck SwMandatoryCheck)
        {
            return SwMandatoryCheckServiceService.AddSwMandatoryCheck(SwMandatoryCheck);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwMandatoryCheck/UpdateSwMandatoryCheck")]
        public SwMandatoryCheck UpdateSwMandatoryCheck(SwMandatoryCheck SwMandatoryCheck)
        {
            return SwMandatoryCheckServiceService.UpdateSwMandatoryCheck(SwMandatoryCheck);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwMandatoryCheck/DeleteSwMandatoryCheck")]
        public SwMandatoryCheck DeleteSwMandatoryCheck(int id)
        {
            return SwMandatoryCheckServiceService.DeleteSwMandatoryCheck(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwMandatoryCheck/GetSwMandatoryCheckById")]
        public SwMandatoryCheck GetSwMandatoryCheckById(int id)
        {
            return SwMandatoryCheckServiceService.GetSwMandatoryCheckById(id);
        }
    }
}
