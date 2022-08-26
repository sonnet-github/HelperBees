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
    public class ClEmergencyContactController : ControllerBase
    {
        private readonly IClEmergencyContactService ClEmergencyContactService;
        public ClEmergencyContactController(IClEmergencyContactService iIClEmergencyContactService)
        {
            ClEmergencyContactService = iIClEmergencyContactService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/GetClEmergencyContact")]
        public IEnumerable<ClEmergencyContact> GetClEmergencyContact()
        {
            return ClEmergencyContactService.GetClEmergencyContact();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/AddClEmergencyContact")]
        public ClEmergencyContact AddClEmergencyContact(ClEmergencyContact ClEmergencyContact)
        {
            return ClEmergencyContactService.AddClEmergencyContact(ClEmergencyContact);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/UpdateClEmergencyContact")]
        public ClEmergencyContact UpdateClEmergencyContact(ClEmergencyContact ClEmergencyContact)
        {
            return ClEmergencyContactService.UpdateClEmergencyContact(ClEmergencyContact);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/DeleteClEmergencyContact")]
        public ClEmergencyContact DeleteClEmergencyContact(int id)
        {
            return ClEmergencyContactService.DeleteClEmergencyContact(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/GetClEmergencyContactById")]
        public ClEmergencyContact GetClEmergencyContactById(int id)
        {
            return ClEmergencyContactService.GetClEmergencyContactById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/GetClEmergencyContactByParticipantId")]
        public IEnumerable<ClEmergencyContact> GetClEmergencyContactByParticipantId(int participantid)
        {
            return ClEmergencyContactService.GetClEmergencyContactByParticipantId(participantid);
        }
    }
}
