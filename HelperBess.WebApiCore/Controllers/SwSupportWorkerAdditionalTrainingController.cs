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
    public class SwSupportWorkerAdditionalTrainingController : ControllerBase
    {
        private readonly ISwSupportWorkerAdditionalTrainingService SwSupportWorkerAdditionalTrainingServiceService;
        public SwSupportWorkerAdditionalTrainingController(ISwSupportWorkerAdditionalTrainingService iSwSupportWorkerAdditionalTrainingService)
        {
            SwSupportWorkerAdditionalTrainingServiceService = iSwSupportWorkerAdditionalTrainingService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/GetSwSupportWorkerAdditionalTraining")]
        public IEnumerable<SwSupportWorkerAdditionalTraining> GetSwSupportWorkerAdditionalTraining()
        {
            return SwSupportWorkerAdditionalTrainingServiceService.GetSwSupportWorkerAdditionalTraining();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/AddSwSupportWorkerAdditionalTraining")]
        public SwSupportWorkerAdditionalTraining AddSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTraining)
        {
            return SwSupportWorkerAdditionalTrainingServiceService.AddSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/UpdateSwSupportWorkerAdditionalTraining")]
        public SwSupportWorkerAdditionalTraining UpdateSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTraining)
        {
            return SwSupportWorkerAdditionalTrainingServiceService.UpdateSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/DeleteSwSupportWorkerAdditionalTraining")]
        public SwSupportWorkerAdditionalTraining DeleteSwSupportWorkerAdditionalTraining(int id)
        {
            return SwSupportWorkerAdditionalTrainingServiceService.DeleteSwSupportWorkerAdditionalTraining(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/GetSwSupportWorkerAdditionalTrainingById")]
        public SwSupportWorkerAdditionalTraining GetSwSupportWorkerAdditionalTrainingById(int id)
        {
            return SwSupportWorkerAdditionalTrainingServiceService.GetSwSupportWorkerAdditionalTrainingById(id);
        }
    }
}
