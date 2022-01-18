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
    public class ClParticipantMedicationController : ControllerBase
    {
        private readonly IClParticipantMedicationService ClParticipantMedicationServiceService;
        public ClParticipantMedicationController(IClParticipantMedicationService iClParticipantMedicationService)
        {
            ClParticipantMedicationServiceService = iClParticipantMedicationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/GetClParticipantMedication")]
        public IEnumerable<ClParticipantMedication> GetClParticipantMedication()
        {
            return ClParticipantMedicationServiceService.GetClParticipantMedication();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/AddClParticipantMedication")]
        public ClParticipantMedication AddClParticipantMedication(ClParticipantMedication ClParticipantMedication)
        {
            return ClParticipantMedicationServiceService.AddClParticipantMedication(ClParticipantMedication);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/UpdateClParticipantMedication")]
        public ClParticipantMedication UpdateClParticipantMedication(ClParticipantMedication ClParticipantMedication)
        {
            return ClParticipantMedicationServiceService.UpdateClParticipantMedication(ClParticipantMedication);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/DeleteClParticipantMedication")]
        public ClParticipantMedication DeleteClParticipantMedication(int id)
        {
            return ClParticipantMedicationServiceService.DeleteClParticipantMedication(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/GetClParticipantMedicationById")]
        public ClParticipantMedication GetClParticipantMedicationById(int id)
        {
            return ClParticipantMedicationServiceService.GetClParticipantMedicationById(id);
        }
    }
}
