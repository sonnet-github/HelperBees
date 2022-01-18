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
    public class SwSupportWorkerOtherTrainingController : ControllerBase
    {
        private readonly ISwSupportWorkerOtherTrainingService SwSupportWorkerOtherTrainingServiceService;
        public SwSupportWorkerOtherTrainingController(ISwSupportWorkerOtherTrainingService iSwSupportWorkerOtherTrainingService)
        {
            SwSupportWorkerOtherTrainingServiceService = iSwSupportWorkerOtherTrainingService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/GetSwSupportWorkerOtherTraining")]
        public IEnumerable<SwSupportWorkerOtherTraining> GetSwSupportWorkerOtherTraining()
        {
            return SwSupportWorkerOtherTrainingServiceService.GetSwSupportWorkerOtherTraining();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/AddSwSupportWorkerOtherTraining")]
        public SwSupportWorkerOtherTraining AddSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTraining)
        {
            return SwSupportWorkerOtherTrainingServiceService.AddSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/UpdateSwSupportWorkerOtherTraining")]
        public SwSupportWorkerOtherTraining UpdateSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTraining)
        {
            return SwSupportWorkerOtherTrainingServiceService.UpdateSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/DeleteSwSupportWorkerOtherTraining")]
        public SwSupportWorkerOtherTraining DeleteSwSupportWorkerOtherTraining(int id)
        {
            return SwSupportWorkerOtherTrainingServiceService.DeleteSwSupportWorkerOtherTraining(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/GetSwSupportWorkerOtherTrainingById")]
        public SwSupportWorkerOtherTraining GetSwSupportWorkerOtherTrainingById(int id)
        {
            return SwSupportWorkerOtherTrainingServiceService.GetSwSupportWorkerOtherTrainingById(id);
        }
    }
}
