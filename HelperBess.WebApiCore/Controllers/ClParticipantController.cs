using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    //////[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class ClParticipantController : ControllerBase
    {
        private readonly IClParticipantService ClParticipantServiceService;
        public ClParticipantController(IClParticipantService iClParticipantService)
        {
            ClParticipantServiceService = iClParticipantService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipant/GetClParticipant")]
        public IEnumerable<ClParticipant> GetClParticipant()
        {
            return ClParticipantServiceService.GetClParticipant();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipant/AddClParticipant")]
        public ClParticipant AddClParticipant(ClParticipant ClParticipant)
        {
            return ClParticipantServiceService.AddClParticipant(ClParticipant);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipant/UpdateClParticipant")]
        public ClParticipant UpdateClParticipant(ClParticipant ClParticipant)
        {
            return ClParticipantServiceService.UpdateClParticipant(ClParticipant);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipant/DeleteClParticipant")]
        public ClParticipant DeleteClParticipant(int id)
        {
            return ClParticipantServiceService.DeleteClParticipant(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipant/GetClParticipantById")]
        public ClParticipant GetClParticipantById(int id)
        {
            return ClParticipantServiceService.GetClParticipantById(id);
        }
    }
}
