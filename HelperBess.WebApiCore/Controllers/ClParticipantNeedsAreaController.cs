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
    public class ClParticipantNeedsAreaController : ControllerBase
    {
        private readonly IClParticipantNeedsAreaService ClParticipantNeedsAreaServiceService;
        public ClParticipantNeedsAreaController(IClParticipantNeedsAreaService iClParticipantNeedsAreaService)
        {
            ClParticipantNeedsAreaServiceService = iClParticipantNeedsAreaService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/GetClParticipantNeedsArea")]
        public IEnumerable<ClParticipantNeedsArea> GetClParticipantNeedsArea()
        {
            return ClParticipantNeedsAreaServiceService.GetClParticipantNeedsArea();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/AddClParticipantNeedsArea")]
        public ClParticipantNeedsArea AddClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsArea)
        {
            return ClParticipantNeedsAreaServiceService.AddClParticipantNeedsArea(ClParticipantNeedsArea);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/UpdateClParticipantNeedsArea")]
        public ClParticipantNeedsArea UpdateClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsArea)
        {
            return ClParticipantNeedsAreaServiceService.UpdateClParticipantNeedsArea(ClParticipantNeedsArea);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/DeleteClParticipantNeedsArea")]
        public ClParticipantNeedsArea DeleteClParticipantNeedsArea(int id)
        {
            return ClParticipantNeedsAreaServiceService.DeleteClParticipantNeedsArea(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/GetClParticipantNeedsAreaById")]
        public ClParticipantNeedsArea GetClParticipantNeedsAreaById(int id)
        {
            return ClParticipantNeedsAreaServiceService.GetClParticipantNeedsAreaById(id);
        }
    }
}
