using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public IActionResult GetSwSupportWorkerOtherTraining()
        {
            try
            {
                List<SwSupportWorkerOtherTraining> swTrainings = SwSupportWorkerOtherTrainingServiceService.GetSwSupportWorkerOtherTraining().ToList();

                if (swTrainings != null && swTrainings.Any())
                {
                    return Ok(swTrainings);
                }
                else
                {
                    return BadRequest("No support worker other training(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/AddSwSupportWorkerOtherTraining")]
        public IActionResult AddSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTraining)
        {
            try
            {
                SwSupportWorkerOtherTraining swTraining = SwSupportWorkerOtherTrainingServiceService.AddSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining);

                if (swTraining != null)
                {
                    return Ok(swTraining);
                }
                else
                {
                    return BadRequest("Failed to add support worker other training.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/UpdateSwSupportWorkerOtherTraining")]
        public IActionResult UpdateSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTraining)
        {
            try
            {
                SwSupportWorkerOtherTraining swCurrentTraining = SwSupportWorkerOtherTrainingServiceService.GetSwSupportWorkerOtherTrainingById(SwSupportWorkerOtherTraining.SupportWorkerOtherTrainingId);

                if (swCurrentTraining != null)
                {
                    swCurrentTraining.SupportWorkerOtherTrainingId = SwSupportWorkerOtherTraining.SupportWorkerOtherTrainingId;
                    swCurrentTraining.SupportWorkerId = SwSupportWorkerOtherTraining.SupportWorkerId;
                    swCurrentTraining.OtherQualification = SwSupportWorkerOtherTraining.OtherQualification;
                    swCurrentTraining.Certificate = SwSupportWorkerOtherTraining.Certificate;

                    SwSupportWorkerOtherTraining swTraining = SwSupportWorkerOtherTrainingServiceService.UpdateSwSupportWorkerOtherTraining(swCurrentTraining);

                    if (swTraining != null)
                    {
                        return Ok(swTraining);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker other training.");
                    }
                }
                else
                {
                    return BadRequest("Support worker other training not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/DeleteSwSupportWorkerOtherTraining")]
        public IActionResult DeleteSwSupportWorkerOtherTraining(int id)
        {
            try
            {
                SwSupportWorkerOtherTraining swCurrentTraining = SwSupportWorkerOtherTrainingServiceService.GetSwSupportWorkerOtherTrainingById(id);

                if (swCurrentTraining != null)
                {
                    SwSupportWorkerOtherTraining swTraining = SwSupportWorkerOtherTrainingServiceService.DeleteSwSupportWorkerOtherTraining(id);

                    return Ok(swTraining);
                }
                else
                {
                    return BadRequest("Support worker other training not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/GetSwSupportWorkerOtherTrainingById")]
        public IActionResult GetSwSupportWorkerOtherTrainingById(int id)
        {
            try
            {
                SwSupportWorkerOtherTraining swTraining = SwSupportWorkerOtherTrainingServiceService.GetSwSupportWorkerOtherTrainingById(id);

                if (swTraining != null)
                {
                    return Ok(swTraining);
                }
                else
                {
                    return BadRequest("Support worker other training not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherTraining/GetSwSupportWorkerOtherTrainingBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerOtherTrainingBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerOtherTraining> swTrainings = SwSupportWorkerOtherTrainingServiceService.GetSwSupportWorkerOtherTrainingBySupportWorkerId(supportWorkerId)?.ToList();

                if (swTrainings != null && swTrainings.Any())
                {
                    return Ok(swTrainings);
                }
                else
                {
                    return NotFound("Support worker other training not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
