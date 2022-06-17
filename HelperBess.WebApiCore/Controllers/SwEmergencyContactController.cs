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
    public class SwEmergencyContactController : ControllerBase
    {
        private readonly ISwEmergencyContactService SwEmergencyContactServiceService;
        public SwEmergencyContactController(ISwEmergencyContactService iSwEmergencyContactService)
        {
            SwEmergencyContactServiceService = iSwEmergencyContactService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEmergencyContact/GetSwEmergencyContact")]
        public IEnumerable<SwEmergencyContact> GetSwEmergencyContact()
        {
            return SwEmergencyContactServiceService.GetSwEmergencyContact();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwEmergencyContact/AddSwEmergencyContact")]
        public SwEmergencyContact AddSwEmergencyContact(SwEmergencyContact SwEmergencyContact)
        {
            return SwEmergencyContactServiceService.AddSwEmergencyContact(SwEmergencyContact);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwEmergencyContact/UpdateSwEmergencyContact")]
        public SwEmergencyContact UpdateSwEmergencyContact(SwEmergencyContact SwEmergencyContact)
        {
            return SwEmergencyContactServiceService.UpdateSwEmergencyContact(SwEmergencyContact);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwEmergencyContact/DeleteSwEmergencyContact")]
        public SwEmergencyContact DeleteSwEmergencyContact(int id)
        {
            return SwEmergencyContactServiceService.DeleteSwEmergencyContact(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEmergencyContact/GetSwEmergencyContactById")]
        public SwEmergencyContact GetSwEmergencyContactById(int id)
        {
            return SwEmergencyContactServiceService.GetSwEmergencyContactById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEmergencyContact/GetSwEmergencyContactBySWId")]
        public IEnumerable<SwEmergencyContact> GetSwEmergencyContactBySWId(int swid)
        {
            return SwEmergencyContactServiceService.GetSwEmergencyContactBySWId(swid);
        }
    }
}
