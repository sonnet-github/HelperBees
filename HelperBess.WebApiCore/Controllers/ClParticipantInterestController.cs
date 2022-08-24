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
    public class ClParticipantInterestController : ControllerBase
    {
        private readonly IClParticipantInterestService ClParticipantInterestServiceService;
        public ClParticipantInterestController(IClParticipantInterestService iClParticipantInterestService)
        {
            ClParticipantInterestServiceService = iClParticipantInterestService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/GetClParticipantInterest")]
        public IEnumerable<ClParticipantInterest> GetClParticipantInterest()
        {
            return ClParticipantInterestServiceService.GetClParticipantInterest();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/AddClParticipantInterest")]
        public ClParticipantInterest AddClParticipantInterest(ClParticipantInterest ClParticipantInterest)
        {
            return ClParticipantInterestServiceService.AddClParticipantInterest(ClParticipantInterest);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/UpdateClParticipantInterest")]
        public ClParticipantInterest UpdateClParticipantInterest(ClParticipantInterest ClParticipantInterest)
        {
            return ClParticipantInterestServiceService.UpdateClParticipantInterest(ClParticipantInterest);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/DeleteClParticipantInterest")]
        public ClParticipantInterest DeleteClParticipantInterest(int id)
        {
            return ClParticipantInterestServiceService.DeleteClParticipantInterest(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/GetClParticipantInterestById")]
        public ClParticipantInterest GetClParticipantInterestById(int id)
        {
            return ClParticipantInterestServiceService.GetClParticipantInterestById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/GetClParticipantInterestByParticipantId")]
        public IEnumerable<ClParticipantInterest> GetClParticipantInterestByParticipantId(int participantid)
        {
            return ClParticipantInterestServiceService.GetClParticipantInterestByParticipantId(participantid);
        }
    }
}
