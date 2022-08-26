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
    public class ClParticipantMedicationInformationController : ControllerBase
    {
        private readonly IClParticipantMedicationInformationService ClParticipantMedicationInformationServiceService;
        public ClParticipantMedicationInformationController(IClParticipantMedicationInformationService iClParticipantMedicationInformationService)
        {
            ClParticipantMedicationInformationServiceService = iClParticipantMedicationInformationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/GetClParticipantMedicationInformation")]
        public IEnumerable<ClParticipantMedicationInformation> GetClParticipantMedicationInformation()
        {
            return ClParticipantMedicationInformationServiceService.GetClParticipantMedicationInformation();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/AddClParticipantMedicationInformation")]
        public ClParticipantMedicationInformation AddClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformation)
        {
            return ClParticipantMedicationInformationServiceService.AddClParticipantMedicationInformation(ClParticipantMedicationInformation);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/UpdateClParticipantMedicationInformation")]
        public ClParticipantMedicationInformation UpdateClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformation)
        {
            return ClParticipantMedicationInformationServiceService.UpdateClParticipantMedicationInformation(ClParticipantMedicationInformation);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/DeleteClParticipantMedicationInformation")]
        public ClParticipantMedicationInformation DeleteClParticipantMedicationInformation(int id)
        {
            return ClParticipantMedicationInformationServiceService.DeleteClParticipantMedicationInformation(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/GetClParticipantMedicationInformationById")]
        public ClParticipantMedicationInformation GetClParticipantMedicationInformationById(int id)
        {
            return ClParticipantMedicationInformationServiceService.GetClParticipantMedicationInformationById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/GetClParticipantMedicationInformationByParticipantId")]
        public IEnumerable<ClParticipantMedicationInformation> GetClParticipantMedicationInformationByParticipantId(int participantid)
        {
            return ClParticipantMedicationInformationServiceService.GetClParticipantMedicationInformationByParticipantId(participantid);
        }
    }
}
