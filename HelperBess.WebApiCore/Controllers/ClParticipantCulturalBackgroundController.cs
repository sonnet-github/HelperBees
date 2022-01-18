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
    public class ClParticipantCulturalBackgroundController : ControllerBase
    {
        private readonly IClParticipantCulturalBackgroundService ClParticipantCulturalBackgroundServiceService;
        public ClParticipantCulturalBackgroundController(IClParticipantCulturalBackgroundService iClParticipantCulturalBackgroundService)
        {
            ClParticipantCulturalBackgroundServiceService = iClParticipantCulturalBackgroundService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/GetClParticipantCulturalBackground")]
        public IEnumerable<ClParticipantCulturalBackground> GetClParticipantCulturalBackground()
        {
            return ClParticipantCulturalBackgroundServiceService.GetClParticipantCulturalBackground();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/AddClParticipantCulturalBackground")]
        public ClParticipantCulturalBackground AddClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackground)
        {
            return ClParticipantCulturalBackgroundServiceService.AddClParticipantCulturalBackground(ClParticipantCulturalBackground);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/UpdateClParticipantCulturalBackground")]
        public ClParticipantCulturalBackground UpdateClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackground)
        {
            return ClParticipantCulturalBackgroundServiceService.UpdateClParticipantCulturalBackground(ClParticipantCulturalBackground);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/DeleteClParticipantCulturalBackground")]
        public ClParticipantCulturalBackground DeleteClParticipantCulturalBackground(int id)
        {
            return ClParticipantCulturalBackgroundServiceService.DeleteClParticipantCulturalBackground(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/GetClParticipantCulturalBackgroundById")]
        public ClParticipantCulturalBackground GetClParticipantCulturalBackgroundById(int id)
        {
            return ClParticipantCulturalBackgroundServiceService.GetClParticipantCulturalBackgroundById(id);
        }
    }
}
