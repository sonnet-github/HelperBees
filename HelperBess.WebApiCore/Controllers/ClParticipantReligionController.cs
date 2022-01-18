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
    public class ClParticipantReligionController : ControllerBase
    {
        private readonly IClParticipantReligionService ClParticipantReligionServiceService;
        public ClParticipantReligionController(IClParticipantReligionService iClParticipantReligionService)
        {
            ClParticipantReligionServiceService = iClParticipantReligionService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/GetClParticipantReligion")]
        public IEnumerable<ClParticipantReligion> GetClParticipantReligion()
        {
            return ClParticipantReligionServiceService.GetClParticipantReligion();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/AddClParticipantReligion")]
        public ClParticipantReligion AddClParticipantReligion(ClParticipantReligion ClParticipantReligion)
        {
            return ClParticipantReligionServiceService.AddClParticipantReligion(ClParticipantReligion);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/UpdateClParticipantReligion")]
        public ClParticipantReligion UpdateClParticipantReligion(ClParticipantReligion ClParticipantReligion)
        {
            return ClParticipantReligionServiceService.UpdateClParticipantReligion(ClParticipantReligion);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/DeleteClParticipantReligion")]
        public ClParticipantReligion DeleteClParticipantReligion(int id)
        {
            return ClParticipantReligionServiceService.DeleteClParticipantReligion(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/GetClParticipantReligionById")]
        public ClParticipantReligion GetClParticipantReligionById(int id)
        {
            return ClParticipantReligionServiceService.GetClParticipantReligionById(id);
        }
    }
}
