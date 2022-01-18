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
    public class ClParticipantNeedController : ControllerBase
    {
        private readonly IClParticipantNeedService ClParticipantNeedServiceService;
        public ClParticipantNeedController(IClParticipantNeedService iClParticipantNeedService)
        {
            ClParticipantNeedServiceService = iClParticipantNeedService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/GetClParticipantNeed")]
        public IEnumerable<ClParticipantNeed> GetClParticipantNeed()
        {
            return ClParticipantNeedServiceService.GetClParticipantNeed();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/AddClParticipantNeed")]
        public ClParticipantNeed AddClParticipantNeed(ClParticipantNeed ClParticipantNeed)
        {
            return ClParticipantNeedServiceService.AddClParticipantNeed(ClParticipantNeed);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/UpdateClParticipantNeed")]
        public ClParticipantNeed UpdateClParticipantNeed(ClParticipantNeed ClParticipantNeed)
        {
            return ClParticipantNeedServiceService.UpdateClParticipantNeed(ClParticipantNeed);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/DeleteClParticipantNeed")]
        public ClParticipantNeed DeleteClParticipantNeed(int id)
        {
            return ClParticipantNeedServiceService.DeleteClParticipantNeed(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/GetClParticipantNeedById")]
        public ClParticipantNeed GetClParticipantNeedById(int id)
        {
            return ClParticipantNeedServiceService.GetClParticipantNeedById(id);
        }
    }
}
