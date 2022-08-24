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
    public class ClParticipantInterestsOtherController : ControllerBase
    {
        private readonly IClParticipantInterestsOtherService ClParticipantInterestsOtherServiceService;
        public ClParticipantInterestsOtherController(IClParticipantInterestsOtherService iClParticipantInterestsOtherService)
        {
            ClParticipantInterestsOtherServiceService = iClParticipantInterestsOtherService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/GetClParticipantInterestsOther")]
        public IEnumerable<ClParticipantInterestsOther> GetClParticipantInterestsOther()
        {
            return ClParticipantInterestsOtherServiceService.GetClParticipantInterestsOther();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/AddClParticipantInterestsOther")]
        public ClParticipantInterestsOther AddClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOther)
        {
            return ClParticipantInterestsOtherServiceService.AddClParticipantInterestsOther(ClParticipantInterestsOther);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/UpdateClParticipantInterestsOther")]
        public ClParticipantInterestsOther UpdateClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOther)
        {
            return ClParticipantInterestsOtherServiceService.UpdateClParticipantInterestsOther(ClParticipantInterestsOther);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/DeleteClParticipantInterestsOther")]
        public ClParticipantInterestsOther DeleteClParticipantInterestsOther(int id)
        {
            return ClParticipantInterestsOtherServiceService.DeleteClParticipantInterestsOther(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/GetClParticipantInterestsOtherById")]
        public ClParticipantInterestsOther GetClParticipantInterestsOtherById(int id)
        {
            return ClParticipantInterestsOtherServiceService.GetClParticipantInterestsOtherById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/GetClParticipantInterestsOtherByParticipantId")]
        public IEnumerable<ClParticipantInterestsOther> GetClParticipantInterestsOtherByParticipantId(int participantid)
        {
            return ClParticipantInterestsOtherServiceService.GetClParticipantInterestsOtherByParticipantId(participantid);
        }
    }
}
